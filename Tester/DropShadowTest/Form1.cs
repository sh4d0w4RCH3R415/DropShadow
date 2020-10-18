using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DropShadow;

namespace DropShadowTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			drpShdw = new DropShadowCS();
			drpShdw.CreateWNDParams(CreateParams);
			drpShdw.CreateDropShadow(this, this);
		}

		DropShadowCS drpShdw;
	}
}
