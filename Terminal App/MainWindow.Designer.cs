namespace Terminal_App;

partial class MainWindow
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        inputText = new System.Windows.Forms.RichTextBox();
        outputText = new System.Windows.Forms.RichTextBox();
        OutCode = new System.Windows.Forms.TextBox();
        execute_button = new System.Windows.Forms.Button();
        Input_Label = new System.Windows.Forms.Label();
        out_Label = new System.Windows.Forms.Label();
        timoutLabel = new System.Windows.Forms.Label();
        outCodeLabel = new System.Windows.Forms.Label();
        TimerTimeout = new System.Windows.Forms.NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)TimerTimeout).BeginInit();
        SuspendLayout();
        // 
        // inputText
        // 
        inputText.Location = new System.Drawing.Point(12, 46);
        inputText.Name = "inputText";
        inputText.Size = new System.Drawing.Size(381, 102);
        inputText.TabIndex = 0;
        inputText.Text = "";
        // 
        // outputText
        // 
        outputText.Location = new System.Drawing.Point(407, 46);
        outputText.Name = "outputText";
        outputText.ReadOnly = true;
        outputText.Size = new System.Drawing.Size(381, 102);
        outputText.TabIndex = 1;
        outputText.Text = "";
        // 
        // OutCode
        // 
        OutCode.BackColor = System.Drawing.SystemColors.Control;
        OutCode.Location = new System.Drawing.Point(346, 177);
        OutCode.Name = "OutCode";
        OutCode.ReadOnly = true;
        OutCode.Size = new System.Drawing.Size(100, 27);
        OutCode.TabIndex = 2;
        OutCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // execute_button
        // 
        execute_button.Location = new System.Drawing.Point(12, 187);
        execute_button.Name = "execute_button";
        execute_button.Size = new System.Drawing.Size(128, 37);
        execute_button.TabIndex = 3;
        execute_button.Text = "Run Command";
        execute_button.UseVisualStyleBackColor = true;
        execute_button.Click += execute_button_Click;
        // 
        // Input_Label
        // 
        Input_Label.Location = new System.Drawing.Point(12, 20);
        Input_Label.Name = "Input_Label";
        Input_Label.Size = new System.Drawing.Size(178, 23);
        Input_Label.TabIndex = 4;
        Input_Label.Text = "Command Field";
        // 
        // out_Label
        // 
        out_Label.Location = new System.Drawing.Point(407, 20);
        out_Label.Name = "out_Label";
        out_Label.Size = new System.Drawing.Size(100, 23);
        out_Label.TabIndex = 5;
        out_Label.Text = "Result";
        // 
        // timoutLabel
        // 
        timoutLabel.Location = new System.Drawing.Point(670, 151);
        timoutLabel.Name = "timoutLabel";
        timoutLabel.Size = new System.Drawing.Size(118, 23);
        timoutLabel.TabIndex = 7;
        timoutLabel.Text = "Max timout(sec)";
        // 
        // outCodeLabel
        // 
        outCodeLabel.Location = new System.Drawing.Point(346, 151);
        outCodeLabel.Name = "outCodeLabel";
        outCodeLabel.Size = new System.Drawing.Size(100, 23);
        outCodeLabel.TabIndex = 8;
        outCodeLabel.Text = "Status code";
        // 
        // TimerTimeout
        // 
        TimerTimeout.Location = new System.Drawing.Point(670, 178);
        TimerTimeout.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
        TimerTimeout.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
        TimerTimeout.Name = "TimerTimeout";
        TimerTimeout.Size = new System.Drawing.Size(120, 27);
        TimerTimeout.TabIndex = 10;
        TimerTimeout.Value = new decimal(new int[] { 20, 0, 0, 0 });
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 231);
        Controls.Add(TimerTimeout);
        Controls.Add(outCodeLabel);
        Controls.Add(OutCode);
        Controls.Add(outputText);
        Controls.Add(inputText);
        Controls.Add(timoutLabel);
        Controls.Add(out_Label);
        Controls.Add(Input_Label);
        Controls.Add(execute_button);
        Location = new System.Drawing.Point(19, 19);
        Text = "Terminal Emulator";
        ((System.ComponentModel.ISupportInitialize)TimerTimeout).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.NumericUpDown TimerTimeout;

    private System.Windows.Forms.Label outCodeLabel;

    private System.Windows.Forms.Label timoutLabel;

    private System.Windows.Forms.Button execute_button;
    private System.Windows.Forms.Label Input_Label;
    private System.Windows.Forms.Label out_Label;

    private System.Windows.Forms.RichTextBox outputText;
    private System.Windows.Forms.TextBox OutCode;

    private System.Windows.Forms.RichTextBox inputText;
    
    #endregion
}