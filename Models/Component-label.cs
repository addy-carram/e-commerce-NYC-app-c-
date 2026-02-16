using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_NYC.Models
{
    public partial class Component_label : Component
    {
        public Component_label()
        {
            InitializeComponent();
        }

        public Component_label(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
