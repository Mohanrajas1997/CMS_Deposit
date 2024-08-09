using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CMS_Model;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;

namespace CMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private IConfiguration _configuration;
        private IHostingEnvironment _hostingEnvironment;
        private readonly IOptions<MySettingsModel> appSettings;
        string ConString;

        public AttachmentController(IConfiguration configuration, IHostingEnvironment hostingEnvironment, IOptions<MySettingsModel> app)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
            appSettings = app;
            ConString = appSettings.Value.mysqlcon;
        }

        [HttpPost("SaveAttachment")]
        public Deposit_Model SaveAttachmentFile(Deposit_Model ObjImageFld)
        {
            Deposit_Model ObjRes = new Deposit_Model();
            try
            {
                ObjRes.attachment_gid = ObjImageFld.attachment_gid;
                var filename = Path.Combine(Convert.ToString(ObjImageFld.attachment_gid) + ".txt");
                string webRootPath = _hostingEnvironment.ContentRootPath;
                string folderName = "AttachmentDeposit";
                // Set a variable to the Documents path.
                webRootPath = Path.Combine(webRootPath, folderName);
                //byte[] imageBytes = Convert.FromBase64String(objimage.imagefile);
                // Write the string array to a new file named "WriteLines.txt".
                //System.IO.File.WriteAllBytes(webRootPath, imageBytes.ToArray());
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(webRootPath, filename)))
                {
                    outputFile.WriteLine(ObjImageFld.attachment_dtls);
                }

            }
            catch (Exception ex)
            {
              
                throw ex;
            }
            return ObjRes;
        }
        [HttpPost("viewimage")]
        public string viewimage(Deposit_Model objimage)
        {
            Deposit_Model view = new Deposit_Model();

            var filename = Path.Combine(Convert.ToString(objimage.attachment_gid) + ".txt");
            string webRootPath = _hostingEnvironment.ContentRootPath;
            string folderName = "AttachmentDeposit";
            // Set a variable to the Documents path.
            webRootPath = Path.Combine(webRootPath, folderName, filename);
            if (System.IO.File.Exists(webRootPath))
            {
                FileStream fileStream = new FileStream(webRootPath, FileMode.Open, FileAccess.ReadWrite);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    view.attachment_dtls = reader.ReadLine();
                }
            }

            return JsonConvert.SerializeObject(view, Formatting.Indented);
            //return view;
        }
    }
}