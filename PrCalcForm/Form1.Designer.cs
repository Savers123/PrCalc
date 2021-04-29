
namespace PrCalcForm
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.TextBox DLText;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.PR_Button = new System.Windows.Forms.Button();
      this.DR_Button = new System.Windows.Forms.Button();
      this.CEText = new System.Windows.Forms.TextBox();
      this.UBText = new System.Windows.Forms.TextBox();
      this.TDText = new System.Windows.Forms.TextBox();
      this.TFText = new System.Windows.Forms.TextBox();
      this.TBText = new System.Windows.Forms.TextBox();
      this.DevLvlUpDown = new System.Windows.Forms.NumericUpDown();
      this.TotalOut = new System.Windows.Forms.TextBox();
      this.TillFate5Out = new System.Windows.Forms.TextBox();
      this.TillD30Out = new System.Windows.Forms.TextBox();
      this.ExpUpDown = new System.Windows.Forms.NumericUpDown();
      this.UBUpDown = new System.Windows.Forms.NumericUpDown();
      this.CalcButton = new System.Windows.Forms.Button();
      DLText = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.DevLvlUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ExpUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.UBUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // PR_Button
      // 
      this.PR_Button.Cursor = System.Windows.Forms.Cursors.Hand;
      this.PR_Button.Location = new System.Drawing.Point(12, 11);
      this.PR_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.PR_Button.Name = "PR_Button";
      this.PR_Button.Size = new System.Drawing.Size(80, 25);
      this.PR_Button.TabIndex = 0;
      this.PR_Button.Text = "PR Calc";
      this.PR_Button.UseVisualStyleBackColor = true;
      this.PR_Button.Click += new System.EventHandler(this.PR_Button_Click);
      // 
      // DR_Button
      // 
      this.DR_Button.Cursor = System.Windows.Forms.Cursors.Hand;
      this.DR_Button.Location = new System.Drawing.Point(122, 12);
      this.DR_Button.Name = "DR_Button";
      this.DR_Button.Size = new System.Drawing.Size(80, 25);
      this.DR_Button.TabIndex = 1;
      this.DR_Button.Text = "DR Calc";
      this.DR_Button.UseVisualStyleBackColor = true;
      this.DR_Button.Click += new System.EventHandler(this.DR_Button_Click);
      // 
      // CEText
      // 
      this.CEText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.CEText.CausesValidation = false;
      this.CEText.Location = new System.Drawing.Point(10, 80);
      this.CEText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.CEText.Name = "CEText";
      this.CEText.ReadOnly = true;
      this.CEText.Size = new System.Drawing.Size(110, 16);
      this.CEText.TabIndex = 6;
      this.CEText.TabStop = false;
      this.CEText.Text = "Current Exp:";
      this.CEText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // UBText
      // 
      this.UBText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.UBText.CausesValidation = false;
      this.UBText.Location = new System.Drawing.Point(10, 110);
      this.UBText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.UBText.Name = "UBText";
      this.UBText.ReadOnly = true;
      this.UBText.Size = new System.Drawing.Size(110, 16);
      this.UBText.TabIndex = 7;
      this.UBText.TabStop = false;
      this.UBText.Text = "Unused Blueprints:";
      this.UBText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // TDText
      // 
      this.TDText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.TDText.CausesValidation = false;
      this.TDText.Location = new System.Drawing.Point(10, 180);
      this.TDText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TDText.Name = "TDText";
      this.TDText.ReadOnly = true;
      this.TDText.Size = new System.Drawing.Size(110, 16);
      this.TDText.TabIndex = 8;
      this.TDText.TabStop = false;
      this.TDText.Text = "BP to D30:";
      this.TDText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // TFText
      // 
      this.TFText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.TFText.CausesValidation = false;
      this.TFText.Cursor = System.Windows.Forms.Cursors.Default;
      this.TFText.Location = new System.Drawing.Point(10, 210);
      this.TFText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TFText.Name = "TFText";
      this.TFText.ReadOnly = true;
      this.TFText.Size = new System.Drawing.Size(110, 16);
      this.TFText.TabIndex = 10;
      this.TFText.TabStop = false;
      this.TFText.Text = "BP to FS5:";
      this.TFText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // TBText
      // 
      this.TBText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.TBText.CausesValidation = false;
      this.TBText.Location = new System.Drawing.Point(10, 240);
      this.TBText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TBText.Name = "TBText";
      this.TBText.ReadOnly = true;
      this.TBText.Size = new System.Drawing.Size(110, 16);
      this.TBText.TabIndex = 12;
      this.TBText.TabStop = false;
      this.TBText.Text = "Total Bluprints:";
      this.TBText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // DevLvlUpDown
      // 
      this.DevLvlUpDown.Location = new System.Drawing.Point(125, 50);
      this.DevLvlUpDown.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
      this.DevLvlUpDown.Name = "DevLvlUpDown";
      this.DevLvlUpDown.Size = new System.Drawing.Size(70, 23);
      this.DevLvlUpDown.TabIndex = 14;
      this.DevLvlUpDown.ValueChanged += new System.EventHandler(this.DevLvlUpDown_ValueChanged);
      // 
      // TotalOut
      // 
      this.TotalOut.CausesValidation = false;
      this.TotalOut.Location = new System.Drawing.Point(125, 240);
      this.TotalOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TotalOut.Name = "TotalOut";
      this.TotalOut.ReadOnly = true;
      this.TotalOut.Size = new System.Drawing.Size(70, 23);
      this.TotalOut.TabIndex = 13;
      this.TotalOut.TabStop = false;
      this.TotalOut.TextChanged += new System.EventHandler(this.TotalOut_TextChanged);
      // 
      // TillFate5Out
      // 
      this.TillFate5Out.CausesValidation = false;
      this.TillFate5Out.Location = new System.Drawing.Point(125, 210);
      this.TillFate5Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TillFate5Out.Name = "TillFate5Out";
      this.TillFate5Out.ReadOnly = true;
      this.TillFate5Out.Size = new System.Drawing.Size(70, 23);
      this.TillFate5Out.TabIndex = 11;
      this.TillFate5Out.TabStop = false;
      this.TillFate5Out.TextChanged += new System.EventHandler(this.TillFate5Out_TextChanged);
      // 
      // TillD30Out
      // 
      this.TillD30Out.CausesValidation = false;
      this.TillD30Out.Location = new System.Drawing.Point(125, 180);
      this.TillD30Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TillD30Out.Name = "TillD30Out";
      this.TillD30Out.ReadOnly = true;
      this.TillD30Out.Size = new System.Drawing.Size(70, 23);
      this.TillD30Out.TabIndex = 9;
      this.TillD30Out.TabStop = false;
      this.TillD30Out.TextChanged += new System.EventHandler(this.TillD30Out_TextChanged);
      // 
      // ExpUpDown
      // 
      this.ExpUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.ExpUpDown.Location = new System.Drawing.Point(125, 80);
      this.ExpUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.ExpUpDown.Name = "ExpUpDown";
      this.ExpUpDown.Size = new System.Drawing.Size(70, 23);
      this.ExpUpDown.TabIndex = 15;
      this.ExpUpDown.ValueChanged += new System.EventHandler(this.ExpUpDown_ValueChanged);
      // 
      // UBUpDown
      // 
      this.UBUpDown.Location = new System.Drawing.Point(125, 110);
      this.UBUpDown.Maximum = new decimal(new int[] {
            513,
            0,
            0,
            0});
      this.UBUpDown.Name = "UBUpDown";
      this.UBUpDown.Size = new System.Drawing.Size(70, 23);
      this.UBUpDown.TabIndex = 16;
      this.UBUpDown.ValueChanged += new System.EventHandler(this.UBUpDown_ValueChanged);
      // 
      // CalcButton
      // 
      this.CalcButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CalcButton.Location = new System.Drawing.Point(75, 144);
      this.CalcButton.Name = "CalcButton";
      this.CalcButton.Size = new System.Drawing.Size(80, 25);
      this.CalcButton.TabIndex = 17;
      this.CalcButton.Text = "Calculate";
      this.CalcButton.UseVisualStyleBackColor = true;
      this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
      // 
      // DLText
      // 
      DLText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      DLText.CausesValidation = false;
      DLText.Location = new System.Drawing.Point(10, 50);
      DLText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      DLText.Name = "DLText";
      DLText.ReadOnly = true;
      DLText.Size = new System.Drawing.Size(110, 16);
      DLText.TabIndex = 5;
      DLText.TabStop = false;
      DLText.Text = "Dev Lvl:";
      DLText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // Form1
      // 
      this.AcceptButton = this.CalcButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(214, 276);
      this.Controls.Add(this.CalcButton);
      this.Controls.Add(this.UBUpDown);
      this.Controls.Add(this.ExpUpDown);
      this.Controls.Add(this.DevLvlUpDown);
      this.Controls.Add(this.TotalOut);
      this.Controls.Add(this.TBText);
      this.Controls.Add(this.TillFate5Out);
      this.Controls.Add(this.TFText);
      this.Controls.Add(this.TillD30Out);
      this.Controls.Add(this.TDText);
      this.Controls.Add(this.UBText);
      this.Controls.Add(this.CEText);
      this.Controls.Add(DLText);
      this.Controls.Add(this.DR_Button);
      this.Controls.Add(this.PR_Button);
      this.ForeColor = System.Drawing.Color.Black;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.ImeMode = System.Windows.Forms.ImeMode.Off;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Azurlane Priority Calulator";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DevLvlUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ExpUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.UBUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button PR_Button;
    private System.Windows.Forms.Button DR_Button;
    private System.Windows.Forms.TextBox DLText;
    private System.Windows.Forms.TextBox CEText;
    private System.Windows.Forms.TextBox UBText;
    private System.Windows.Forms.TextBox TDText;
    private System.Windows.Forms.TextBox TFText;
    private System.Windows.Forms.TextBox TBText;
    private System.Windows.Forms.NumericUpDown DevLvlUpDown;
    public System.Windows.Forms.TextBox TotalOut;
    public System.Windows.Forms.TextBox TillFate5Out;
    public System.Windows.Forms.TextBox TillD30Out;
    private System.Windows.Forms.NumericUpDown ExpUpDown;
    private System.Windows.Forms.NumericUpDown UBUpDown;
    private System.Windows.Forms.Button CalcButton;
  }
}