using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public partial class FrmPersonUpdateSalary : Form
		{
		private Person mRefPerson;

		///////////////////////////////////////////////
		public FrmPersonUpdateSalary(Person person)
			{
			InitializeComponent();
			mRefPerson=person;
			}

		///////////////////////////////////////////////
		private void FrmPersonUpdateSalary_Load(object sender, EventArgs e)
			{
			mLblName.Text = mRefPerson.GetName();
			mTxtSalary.Text = mRefPerson.GetSalary().ToString();
			}

		///////////////////////////////////////////////
		private void mCmdUpdate_Click(object sender, EventArgs e)
			{
			decimal newsalary;
			if(decimal.TryParse(mTxtSalary.Text,out newsalary)==false)
				{
				MessageBox.Show("Salary is not a number","Error");
				return;
				}

			// Will Throw an exception if new salary is negative
			mRefPerson.SetSalary(newsalary);

			this.Close();
			}


		////////////////////////////////////////////
		private void mCmdRevert_Click(object sender, EventArgs e)
			{
			mTxtSalary.Text = mRefPerson.GetSalary().ToString();
			}

		/////////////////////////////////////////////
		private void mCmdCancel_Click(object sender, EventArgs e)
			{
			this.Close();
			}

		}
