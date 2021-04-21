using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudinaryApiUsage.WinForm.Helper
{
    static class Upload
    {
        const string cloudname = ".....";
        const string apikey = ".......";
        const string apisecret = "........";

        [Obsolete]
        public static string UploadImage(string path)
        {
            Account account = new Account(cloudname, apikey, apisecret);
            Cloudinary cloudinary = new Cloudinary(account);

            var uploadparams = new ImageUploadParams()
            {
                File = new FileDescription(path)
            };

            //uploadparams.Folder = "[klasör adı]"; // busarı isteğe bağlı 

            var uploadResult=cloudinary.Upload(uploadparams);   // buradan isteğe bağlı olarak görselin kayıt edildiği urli elde edebilirsiniz.
            return uploadResult.Uri.AbsoluteUri;
        }
    }
}
