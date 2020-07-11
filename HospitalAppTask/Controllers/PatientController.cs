using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using HospitalAppTask.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace HospitalAppTask.Controllers
{
    [Authorize]
    public class PatientController : Controller
    {
        public IPatientRepository Repository { get; }
        public IGetDataRepostory GetData { get; }
       // public Disease _Disease { get; set; }

        public PatientController(IPatientRepository repository,IGetDataRepostory getData )
        {
            Repository = repository;
            GetData = getData;
           
        }



        public async Task<IActionResult> Index()
        {
            
            return View( await Repository.GetAllPatient());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        { 
            
            ViewBag.NationalityId = await GetData.GetNationalities();
            ViewBag.KindOfPatientId = await GetData.GetKindOfPatients();
            ViewBag.DoctorId = await GetData.GetDoctors();
            ViewBag.DepartmentId = await GetData.GetDepartments();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Patient patientNew ,Disease disease)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.NationalityId = await GetData.GetNationalities();
                ViewBag.KindOfPatientId = await GetData.GetKindOfPatients();
                ViewBag.DoctorId = await GetData.GetDoctors();
                ViewBag.DepartmentId = await GetData.GetDepartments();
                return View();
            }
                

            if (patientNew == null)
                return View();

            foreach (var file in Request.Form.Files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                patientNew.IdImgPath = ms.ToArray();

                ms.Close();
                ms.Dispose();
            }

            if (disease!=null)
            {
                patientNew.SickHistory = true;
                patientNew.Diseases.Add(disease);
            }
            else { patientNew.SickHistory = false; }
            await Repository.Create(patientNew);
                return RedirectToAction("index");
                
        }
        [HttpGet]
        public  IActionResult CDisease()
        {
            return PartialView();
        }

       
    }
}