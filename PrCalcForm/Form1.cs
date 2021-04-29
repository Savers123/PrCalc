using System;
using System.Windows.Forms;

namespace PrCalcForm
{
  public partial class Form1 : Form
  {
    class Global
    {
      public static string ResearchType = "PR";
      public static int dEVLVL, tRBD30, tRBF5, tB, eXP, uB;
    }
    public Form1()
    {InitializeComponent();}
    public void PRMath()
    {
      int[] PRDevlvl = new int[36] { 0, 2, 4, 6, 8, 13, 17, 21, 25, 29, 37, 43, 49, 55, 61, 73, 83, 93, 103, 113, 133, 148, 163, 178, 193, 223, 243, 263, 283, 303, 343, 353, 373, 403, 443, 508 };
      Global.tRBD30 = 343 - PRDevlvl[Global.dEVLVL] - Global.eXP - Global.uB;
      if (Global.tRBD30 < 0)
      {
        Global.tRBD30 = 0;
      }
      Global.tRBF5 = 508 - PRDevlvl[Global.dEVLVL] - Global.eXP - Global.uB;
      if (Global.tRBF5 < 0)
      {
        Global.tRBF5 = 0;
      }
      Global.tB = PRDevlvl[Global.dEVLVL] + Global.eXP + Global.uB;
    }
    public void DRMath()
    {
      int[] DRDevlvl = new int[31] { 0, 3, 6, 9, 12, 20, 26, 32, 38, 44, 56, 65, 74, 83, 92, 110, 125, 140, 155, 170, 200, 222, 244, 266, 288, 333, 363, 393, 423, 453, 513 };
      Global.tRBD30 = 513 - DRDevlvl[Global.dEVLVL] - Global.eXP - Global.uB;
      if (Global.tRBD30 < 0)
      {
        Global.tRBD30 = 0;
      }
    }
    private void Form1_Load(object sender, EventArgs e)
    { }
    private void PR_Button_Click(object sender, EventArgs e)
    {
      if (Global.ResearchType != "PR")
      {
        Global.ResearchType = "PR";
      }
      TFText.Visible = true;
      TillFate5Out.Visible = true;
      TillD30Out.Text = "";
      TillFate5Out.Text = "";
      TotalOut.Text = "";
    }
    private void DR_Button_Click(object sender, EventArgs e)
    {
      if (Global.ResearchType != "DR")
      {
        Global.ResearchType = "DR";
      }
      TFText.Visible = false;
      TillFate5Out.Visible = false;
      TillD30Out.Text = "";
      TotalOut.Text = "";
    }
    private void CalcButton_Click(object sender, EventArgs e)
    {
      Global.dEVLVL = (int)DevLvlUpDown.Value;
      Global.eXP = (int)ExpUpDown.Value / 10;
      Global.uB = (int)UBUpDown.Value;
      if (Global.ResearchType == "PR")
      { PRMath(); }
      if (Global.ResearchType == "DR")
      { DRMath(); }
      else { }
      TillD30Out.Text = Global.tRBD30.ToString();
      TillFate5Out.Text = Global.tRBF5.ToString();
      TotalOut.Text = Global.tB.ToString();
    }
    private void TillD30Out_TextChanged(object sender, EventArgs e)
    { }
    private void TillFate5Out_TextChanged(object sender, EventArgs e)
    { }
    private void TotalOut_TextChanged(object sender, EventArgs e)
    { }
    private void DevLvlUpDown_ValueChanged(object sender, EventArgs e)
    { }
    private void ExpUpDown_ValueChanged(object sender, EventArgs e)
    { }
    private void UBUpDown_ValueChanged(object sender, EventArgs e)
    { }
  }
}
