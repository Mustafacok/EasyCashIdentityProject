﻿using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    [Authorize]
    public class MyAccountsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MyAccountsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto();
            appUserEditDto.Name =values.Name;
            appUserEditDto.PhoneNumber = values.PhoneNumber;
            appUserEditDto.Surname = values.Surname;
            appUserEditDto.Email = values.Email;
            appUserEditDto.ImageUrl = values.ImageUrl;
            appUserEditDto.City = values.City;
            appUserEditDto.District = values.District;

            return View(appUserEditDto);
        }

    }
}
