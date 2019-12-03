using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //2019-12-03 yuanhuihai

        GetPlcDBW operatePlc = new GetPlcDBW();//类的实例化

        private void button2_Click(object sender, EventArgs e)
        {            
            execResult.Text = Convert.ToString(operatePlc.getPlcDbwValue(plcIp.Text, Convert.ToInt32(plcRack.Text), 
                              Convert.ToInt32(PlcSlot.Text), Convert.ToInt32(DBNum.Text), Convert.ToInt32(DBWNum.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
           operatePlc.resetPlcDbwValue(plcIp.Text, Convert.ToInt32(plcRack.Text), Convert.ToInt32(PlcSlot.Text),
                     Convert.ToInt32(DBNum.Text), Convert.ToInt32(DBWNum.Text),Convert.ToInt32(writeValue.Text));
        }
    }
}
