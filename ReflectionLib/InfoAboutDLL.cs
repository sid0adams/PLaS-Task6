﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionLib
{
    public class InfoAboutDLL
    {
        public Assembly Asm { get; private set; }
        public Type[] types { get; private set; }
        public InfoAboutDLL(Assembly asm)
        {
            Asm = asm;
            Type[] AllTypes = asm.GetTypes();
            List<Type> filtred = new List<Type>();
            foreach (var item in AllTypes)
            {
                if (!item.IsAbstract)
                    filtred.Add(item);
            }
            types = filtred.ToArray();
        }
        public InfoAboutDLL(string path) : 
            this(Assembly.LoadFile(path))
        { }
        public List<string> GetTypesNames()
        {
            List<string> names = new List<string>();
            foreach (var item in types)
            {
                StringBuilder sb = new StringBuilder();
                if (item.IsClass)
                {
                    if (item.IsAbstract)
                        sb.Append("abstract ");
                    sb.Append("class ");
                }
                if (item.IsInterface)
                    sb.Append("interface ");
                sb.Append(item.Name);
                names.Add(sb.ToString());
            }
            return names;
        }
    }
}
