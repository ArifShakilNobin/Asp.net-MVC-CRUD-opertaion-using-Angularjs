using Microsoft.Reporting.WebForms;
using MVC_STUDENT_INFO_ANGULARJS.Models;
using MVC_STUDENT_INFO_ANGULARJS.Repository;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace MVC_STUDENT_INFO_ANGULARJS.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository rep = new StudentRepository();
       
        public ActionResult Index()
        {  
            return View();
        }

        [HttpGet]
        public JsonResult GetAllStudents()
        {
            List<Student> obj = rep.SelectAllStudents();
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetStudentById(int id)
        {
            Student obj = rep.SelectAllStudents().Find(x=>x.StudentID.Equals(id));
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void InsertStudent(Student st)
        {            
            rep.InsertStudent(st);           
        }

        [HttpPost]
        public void UpdateStudent(Student st)
        {
            rep.UpdateStudent(st);
        }

        [HttpPost]
        public void DeleteStudent(int id)
        {
            rep.DeleteStudent(id);            
        }       


        public ActionResult About()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult StudentInfo()
        {
            return View(rep.SelectAllStudents());
        }

        public ActionResult Reports(string ReportType)
        {

            //ReportViewer rpt = new ReportViewer();
            //var list = rep.SelectAllStudents();
            //rpt.LocalReport.DataSources.Add(new ReportDataSource("StudentDataSet",list));
            //rpt.ProcessingMode = ProcessingMode.Local;
            //rpt.Width = System.Web.UI.WebControls.Unit.Percentage(100);
            //rpt.LocalReport.ReportPath = Server.MapPath("~/Reports/StudentReport.rdlc");
            //rpt.LocalReport.EnableExternalImages = true;
            //rpt.LocalReport.Refresh();

            //Warning[] warnings;
            //string[] streamIds;

            //string mimeType = string.Empty;
            //string encoding = string.Empty;
            //string extension = string.Empty;
            //byte[] bytes = rpt.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);
            //return File(bytes, "application/pdf");






            //LocalReport localReport = new LocalReport();
            //localReport.ReportPath = Server.MapPath("~/Reports/StudentReport.rdlc");
            //ReportDataSource reportDataSource = new ReportDataSource();
            //reportDataSource.Name = "StudentDataSet";
            //reportDataSource.Value = rep.SelectAllStudents();
            //localReport.DataSources.Add(reportDataSource);

            //string reportType = ReportType;
            //string mimeTime;
            //string encoding;
            //string fileNameExtrention;

            //if (ReportType == "PDF")
            //{
            //    fileNameExtrention = "pdf";
            //}

            //string[] streams;
            //Microsoft.Reporting.WebForms.Warning[] warnings;
            //byte[] renderdByte;

            //renderdByte = localReport.Render(reportType, "", out mimeTime, out encoding, out fileNameExtrention, out streams, out warnings);


            //Response.AddHeader("Content Description", "Attesment;fileName=studentReport." + fileNameExtrention);
            //return File(renderdByte, fileNameExtrention);
































        }
     
    }
}
