using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionLib
{
    public class InfoAboutType
    {
        public Type SelectedType { get; private set; }
        public object CurnetObject { get; private set; }
        public PropertyInfo[] Properties { get; private set; }
        public ConstructorInfo[] Constructors { get; private set; }
        public MethodInfo[] Methods { get; private set; }
        public Type[] Interfaces { get; private set; }
        public InfoAboutType(Type selectedType)
        {
            SelectedType = selectedType;
            Properties = SelectedType.GetProperties();
            Constructors = SelectedType.GetConstructors();
            Methods = SelectedType.GetMethods();
            Interfaces = SelectedType.GetInterfaces();
        }
        public List<string> GetProperties()
        {
            List<string> prop = new List<string>();
            foreach (var item in Properties)
            {
                string t = item.PropertyType.Name + " " + item.Name;
                try
                {
                    t += " " +item.GetValue(CurnetObject);
                }
                catch (Exception)
                {}
                prop.Add(t);
            }
            return prop;
        }
        public List<string> GetConstructors()
        {
            List<string> constr = new List<string>();
            foreach (var item in Constructors)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(SelectedType.Name + "(");
                ParameterInfo[] parameters = item.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    sb.Append(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length)
                        sb.Append(", ");
                }
                sb.Append(")");
                constr.Add(sb.ToString());
            }
            return constr;
        }
        public List<string> GetMethods()
        {
            List<string> met = new List<string>();
            foreach (var item in Methods)
            {
                StringBuilder sb = new StringBuilder();
                if (item.IsAbstract)
                    sb.Append("abstracat ");
                sb.Append(item.ReturnType.Name + " " + item.Name + "(");
                ParameterInfo[] parameters = item.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    sb.Append(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length)
                        sb.Append(", ");
                }
                sb.Append(")");
                met.Add(sb.ToString());
            }
            return met;
        }
        public List<string> GetInterfaces()
        {
            List<string> inter = new List<string>();
            foreach (var item in Interfaces)
            {
                inter.Add(item.Name);
            }
            return inter;
        }
        public void RunConstructor(int index, object[] param)
        {
            CurnetObject = Constructors[index].Invoke(param);
        }
        public object RunMethod(int index, object[] param)
        {
            if (Methods[index].IsStatic)
                return Methods[index].Invoke(null, param);
            if(CurnetObject!=null)
                return Methods[index].Invoke(CurnetObject, param);
            return null;
        }
        public List<Type> GetParamConstructor(int index)
        {
            List<Type> types = new List<Type>();
            foreach (var item in Constructors[index].GetParameters())
            {
                types.Add(item.ParameterType);
            }
            return types;
        }
        public List<Type> GetParamMethod(int index)
        {
            List<Type> types = new List<Type>();
            foreach (var item in Methods[index].GetParameters())
            {
                types.Add(item.ParameterType);
            }
            return types;
        }
    }
}
