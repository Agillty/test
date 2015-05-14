using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace quiz5
{
    public partial class Form1 : Form
    {
        //static Shape3D[] myshape = new Shape3D[100];
        ArrayList myshape=new ArrayList();
        public double[] densityInfo = { 2.7, 7.87, 11.3 };
        public Form1()
        {
            InitializeComponent();
            comboBoxMaterial.SelectedIndex = 0;
            comboBoxShape.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double density=densityInfo[comboBoxMaterial.SelectedIndex];
            switch(comboBoxShape.SelectedIndex)
            {
                case 0:
                    Ball ball = new Ball(density, Convert.ToDouble(txtPara1.Text));
                    myshape.Add(ball);
                    break;
                case 1:
                    Cube cube = new Cube(density, Convert.ToDouble(txtPara1.Text));
                    myshape.Add(cube);
                    break;
                case 2:
                    Cylinder cylinder = new Cylinder(density, Convert.ToDouble(txtPara1.Text), Convert.ToDouble(txtPara2.Text));
                    myshape.Add(cylinder);
                    break;
                default:
                    Pyramid pyramid = new Pyramid(density, Convert.ToDouble(txtPara1.Text), Convert.ToDouble(txtPara2.Text));
                    myshape.Add(pyramid);
                    break;
            }

            string msg = ((Shape3D)myshape[Shape3D.Amount - 1]).ShowProperty();
            txtProperty.AppendText( msg + Environment.NewLine);
            txtAmount.Text= Shape3D.Amount.ToString();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            for(int i=0;i<Shape3D.Amount;i++)
            {
                txtDisplay.AppendText(((Shape3D)myshape[i]).ShowResult() + Environment.NewLine);
            }
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxShape.SelectedIndex)
            {
                case 0:
                    lblPara1.Text = "半徑";
                    lblPara2.Visible = false;
                    txtPara2.Visible = false;
                    break;
                case 1:
                    lblPara1.Text = "邊長";
                    lblPara2.Visible = false;
                    txtPara2.Visible = false;
                    break;
                case 2:
                    lblPara1.Text = "半徑";
                    lblPara2.Text = "高";
                    lblPara2.Visible = true;
                    txtPara2.Visible = true;
                    break;
                case 3:
                    lblPara1.Text = "底邊";
                    lblPara2.Text = "高";
                    lblPara2.Visible = true;
                    txtPara2.Visible = true;
                    break;

            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if(radioButtonDecrease.Checked==true)
            {
                switch(comboBoxSortBy.SelectedIndex)
                {
                    case 0:
                        BubbleSort(myshape,SortByVolDecrease);
                        break;
                    case 1:
                        BubbleSort(myshape,SortByWeightDecrease);
                        break;
                    default:
                        break;
                }
            }
            else if(radioButtonInecrease.Checked==true)
            {
                switch (comboBoxSortBy.SelectedIndex)
                {
                    case 0:
                        BubbleSort(myshape,SortByVolIncrease);
                        break;
                    case 1:
                        BubbleSort(myshape,SortByWeightIncrease);
                        break;
                    default:
                        break;
                }
            }

            txtDisplay.Clear();
            for (int i = 0; i < Shape3D.Amount; i++)
            {
                txtDisplay.AppendText(((Shape3D)myshape[i]).ShowResult() + Environment.NewLine);
            }


        }


        private bool SortByWeightIncrease(Shape3D shape1, Shape3D shape2)
        {
            if (shape1.Weight() > shape2.Weight())
            {
                return true;
            }
            else return false;
        }
        private bool SortByWeightDecrease(Shape3D shape1, Shape3D shape2)
        {
            if (shape1.Weight() < shape2.Weight())
            {
                return true;
            }
            else return false;
        }
        private bool SortByVolIncrease(Shape3D shape1, Shape3D shape2)
        {
            if (shape1.Volume() > shape2.Volume())
            {
                return true;
            }
            else return false;
        }
        private bool SortByVolDecrease(Shape3D shape1, Shape3D shape2)
        {
            if (shape1.Volume() < shape2.Volume())
            {
                return true;
            }
            else return false;
        }

        private delegate bool Compare(Shape3D shape1, Shape3D shape2);

        private void BubbleSort(ArrayList arr, Compare cmp)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count - 1; j++)
                {
                    if (cmp((Shape3D)arr[i], (Shape3D)arr[j]))
                    {
                        Shape3D temp;
                        temp = (Shape3D)arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }


    }
}
