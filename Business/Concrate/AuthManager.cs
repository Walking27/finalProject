using Business.Abstract;
using Business.Constants;
using Core.Entities.Comcrate;
using Core.Utilites.Results;
using Core.Utilites.Security.Hasing;
using Core.Utilites.Security.JWT;
using Entities.DTOs;
using System;
using System.Text;

namespace Business.Concrate
{
    public class AuthManager:IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HasingHelper.CreatePasswordHash(password,out passwordHash,out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PaswordHash = passwordHash,
                PaswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return  new SuccesDataResult<User>(user, "Kayıt Oldu");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck==null)
            {
                return new ErrorDataResult<User>("Kullanıcı Bulunamadı");
            }

            if (!HasingHelper.VerifyPasswordHash(userForLoginDto.Password,userToCheck.PaswordHash,userToCheck.PaswordSalt))
            {
                return new ErrorDataResult<User>("Parola Hatası");
            }

            return new SuccesDataResult<User>(userToCheck, "Başarılı Giriş");
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email)!=null)
            {
                return new ErrorResult("Kullanıcı Mevcut");
            }
            return new SuccessResault();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccesDataResult<AccessToken>(accessToken, "Başarılı");
        }
    }
}
