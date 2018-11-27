using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReflectionLib;
using System.Reflection;

namespace ReflectionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        InfoAboutDLL DLL;
        InfoAboutType type;
        private void UpdList(ListBox list, List<string> data)
        {
            list.Items.Clear();
            list.Items.AddRange(data.ToArray());
        }
        private void UpdClassList()
        {
            UpdList(ClassList, DLL.GetTypesNames());
        }
        private void UpdType()
        {
            UpdList(PropertiesList, type.GetProperties());
            UpdList(MethodsList, type.GetMethods());
            UpdList(InterfacesList, type.GetInterfaces());
            UpdList(ConstructorsList, type.GetConstructors());
        }
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DLL = new InfoAboutDLL(openFileDialog.FileName);
                UpdClassList();
            }
        }

        private void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = new InfoAboutType(DLL.types[ClassList.SelectedIndex]);
            UpdType();
        }
        private List<object> InputParams(ParameterInfo[] types)
        {
            foreach (var item in types)
            {
                if (item.ParameterType != typeof(int) && item.ParameterType != typeof(string))
                    return null;
            }
            List<object> list = new List<object>();
            foreach (var item in types)
            {
                if (item.ParameterType == typeof(int))
                {
                    GetInt getInt = new GetInt(item.Name);
                    if (getInt.ShowDialog() == DialogResult.OK)
                    {
                        list.Add(getInt.Value);
                    }
                    else return null;
                }
                else
                {
                    GetStr getStr = new GetStr(item.Name);
                    if (getStr.ShowDialog() == DialogResult.OK)
                    {
                        list.Add(getStr.Value);
                    }
                    else return null;
                }
            }
            return list;
        }

        private void constr_Click(object sender, EventArgs e)
        {
            if (type == null)
                return;
            int index = ConstructorsList.SelectedIndex;
            if (index>=0 && index<type.Constructors.Length)
            {
                List<Type> types = type.GetParamConstructor(index);
                List<object> param = InputParams(type.Constructors[index].GetParameters());
                if (param == null)
                    return;
                type.RunConstructor(index, param.ToArray());
                UpdType();
            }
        }

        private void MethodsBtn_Click(object sender, EventArgs e)
        {
            if (type == null)
                return;
            int index = MethodsList.SelectedIndex;
            if (index >= 0 && index < type.Methods.Length)
            {
                List<Type> types = type.GetParamMethod(index);
                List<object> param = InputParams(type.Methods[index].GetParameters()); if (param == null)
                    return;
                object ret = type.RunMethod(index, param.ToArray());
                if (ret != null)
                    output.Text = ret.ToString();
                else
                    output.Text = "";
                UpdType();
            }
        }
    }
}
