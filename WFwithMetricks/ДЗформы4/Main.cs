using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ДЗформы4
{
    static class Main
    {
        public static int loc = 0, noc = 0, nom = 0, nop = 0, cyclo = 0, bovr = 0, atfd = 0;
        //@"C://hodoku";
        static List<string> classes = new List<string>(0);
        public static void Start(string path)
        {
            classes.Add("void");
            classes.Add("int");
            classes.Add("int[]");
            classes.Add("string");
            classes.Add("string[]");
            classes.Add("bool");
            classes.Add("bool[]");
            classes.Add("float");
            classes.Add("float[]");
            classes.Add("double");
            classes.Add("double[]");
            classes.Add("char");
            classes.Add("char[]");
            Analyze_Folder(path);
            Analyze_Folder_NOM(path);
            //Console.WriteLine("classes: " + classes.Count); // это не кол-во классов всего
        }
        static void Analyze_File_NOM(string path)
        {
            int comments = 0;
            string[] strngs = System.IO.File.ReadAllLines(path);
            foreach (string strng in strngs)
            {
                if (strng.IndexOf(@"/*") > -1)
                {
                    comments++;
                }
                if (strng.IndexOf(@"*/") > -1)
                {
                    comments--;
                }
                if (strng.IndexOf(@"//") == -1 && comments == 0)
                {
                    Get_Nom_from_File(strng);
                }
            }
        }
        static void Get_Nom_from_File(string strng)//принимает строку разделяет на слова и добавляет клас в список классов
        {
            string[] strngs = strng.Split(' ');
            for (int i = 0; i < strngs.Length; i++)
            {
                for (int j = 0; j < classes.Count; j++)
                {
                    if (strngs[i] == classes[j])
                    {
                        try
                        {
                            if (strngs[i + 1].IndexOf("(") > -1)
                            {
                                nom++;
                            }
                            if (strngs[i + 2].IndexOf("(") > -1)
                            {
                                nom++;
                            }
                        }
                        catch { }
                    }
                }
            }
        }
        public static void Analyze_Folder_NOM(string path)
        {
            Console.WriteLine();
            string[] folders = Directory.GetDirectories(path);
            string[] javaFiles = Directory.GetFiles(path, "*.java");
            foreach (string javaFile in javaFiles)
            {
                Analyze_File_NOM(javaFile);
            }
            foreach (string folder in folders)
            {
                Analyze_Folder_NOM(folder);
            }
        }
        static void Analyze_File(string path)
        {
            int comments = 0;
            string[] strngs = System.IO.File.ReadAllLines(path);
            loc += strngs.Length;
            foreach (string strng in strngs)
            {
                if (strng.IndexOf(@"/*") > -1)
                {
                    comments++;
                }
                if (strng.IndexOf(@"*/") > -1)
                {
                    comments--;
                }
                if ((strng.IndexOf("if") > -1 || strng.IndexOf("else") > -1 || strng.IndexOf("case") > -1 || strng.IndexOf("?") > -1) && strng.IndexOf(@"//") == -1 && comments == 0)
                {
                    cyclo++;
                }
                if (strng.IndexOf("override") > -1 && strng.IndexOf(@"//") == -1 && comments == 0)
                {
                    bovr++;
                }
                if ((strng.IndexOf("set") > -1 || strng.IndexOf("get") > -1) && strng.IndexOf(@"//") == -1 && comments == 0)
                {
                    atfd++;
                }
                if (strng.IndexOf("class") > -1 && strng.IndexOf(@"//") == -1 && comments == 0)
                {
                    noc++;
                    GetClasses(strng);
                }
            }
        }
        static void GetClasses(string strng)//принимает строку разделяет на слова и добавляет клас в список классов
        {
            string[] strngs = strng.Split(' ');
            for (int i = 0; i < strngs.Length; i++)
            {
                if (strngs[i] == "class")
                {
                    string clas = "";
                    if (strngs[i + 1].IndexOf("(") > -1)
                    {
                        clas = strngs[i + 1].Remove(strngs[i + 1].IndexOf("("));
                    }
                    else
                        clas = strngs[i + 1];
                    classes.Add(clas);
                }
            }
        }
        //---------------------------------------------------------------------------
        public static void Analyze_Folder(string path)
        {
            //Console.WriteLine();
            //Console.WriteLine("Root path: " + path);            
            string[] folders = Directory.GetDirectories(path);
            string[] javaFiles = Directory.GetFiles(path, "*.java");
            if (folders.Length == 0 && javaFiles.Length > 0)
            {
                nop++;
            }
            foreach (string folder in folders)
            {
                //Console.WriteLine(folder);                
            }
            foreach (string javaFile in javaFiles)
            {
                //Console.WriteLine(javaFile);
            }
            foreach (string javaFile in javaFiles)
            {
                Analyze_File(javaFile);
            }
            foreach (string folder in folders)
            {
                Analyze_Folder(folder);
            }
        }
        //---------------------------------------------------------------------------
    }
}
