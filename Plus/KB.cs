﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus
{
    public class KB
    {

        /*public static string gcp_file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\inovation digital works\snippetsplus\snippetsjson\gcp.json";
        public static string android_file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\inovation digital works\snippetsplus\snippetsjson\android.json";
        public static string kubernetes_file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\inovation digital works\snippetsplus\snippetsjson\kubernetes.json";*/


        public static List<string> sections = new List<string>(){
            "Android",
            "Google Cloud Platform",
            "Kubernetes"
        };

        public static Dictionary<string, string> files = new Dictionary<string, string>()
        {
            {sections[0], Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\inovation digital works\snippetsplus\snippetsjson\android.json" },
            {sections[1], Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\inovation digital works\snippetsplus\snippetsjson\gcp.json" },
            {sections[2], Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\inovation digital works\snippetsplus\snippetsjson\kubernetes.json" }
        };


    }
}
