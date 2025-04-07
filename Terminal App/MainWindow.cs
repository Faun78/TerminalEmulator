namespace Terminal_App;
using System.Diagnostics;
using System.Threading;
public partial class MainWindow : Form
{
    #region Constants
    private const int MaxTimeout = 300; // Set max timeout to 5 minutes
    private const int MinTimeout = 5; // Set min timeout to 5 seconds
    #endregion

    public MainWindow()
    {
        InitializeComponent();
        TimerTimeout.Minimum=MinTimeout;
        TimerTimeout.Maximum=MaxTimeout;
    }
    
    private static void AppendText(ref RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }

    private static Color GetTextColor(int outputCode)
    {
        switch (outputCode)
        {
            case 0:
                return Color.Black;
            case 2:
                return Color.Yellow;
            default:
                return Color.Red;
        }
    }
    
    private void ExecuteTextInput(object? stateInfo)
    {
        string toExecute = inputText.Text;
        
        Process command = new Process();
        command.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        command.StartInfo.FileName = "cmd.exe";
        command.StartInfo.RedirectStandardOutput = true;
        command.StartInfo.RedirectStandardError = true;
        command.StartInfo.Arguments = "/C " + toExecute;
        
        try
        {
            command.Start();
            bool exited = command.WaitForExit(Convert.ToInt32(TimerTimeout.Value)*1000);
            Color textColor = GetTextColor(command.ExitCode);
            OutCode.Text = command.ExitCode.ToString();
            OutCode.BackColor = textColor == Color.Black ? Color.LightGreen : Color.LightCoral;
            if (!exited)
            {
                command.Kill();
                AppendText(ref outputText,"Timeout was reached\n", Color.Red);
                execute_button.Enabled = true;
                return;
            }
            AppendText(ref outputText, command.StandardOutput.ReadToEnd(), textColor);

            if (command.ExitCode != 0 && !command.StandardError.EndOfStream)
            {
                AppendText(ref outputText,"\nStderr message:\n" + command.StandardError.ReadToEnd(), textColor);
            }
        }
        catch (Exception e)
        {
            OutCode.Text = "-1";
            OutCode.BackColor = Color.OrangeRed;
            if (e.GetType() == typeof(InvalidOperationException))
            {
                AppendText(ref outputText,"Failed to execute command as the CMD is not in $PATH\n", Color.Red);
            }
            else if (e.GetType() == typeof(System.ComponentModel.Win32Exception))
            {
                AppendText(ref outputText,"Failed the execution of command\n", Color.Red);
            }
            else if (e.GetType() == typeof(OutOfMemoryException))
            {
                AppendText(ref outputText,"The output of the command was too large to display\n", Color.Red);
            }
            else
            {
                AppendText(ref outputText,"Unhandled exception occured:\n"+e.Message,Color.Red);
            }
        }
        execute_button.Enabled = true;
    }
    
    # region Event Handlers
    private void execute_button_Click(object sender, EventArgs e)
    {
        execute_button.Enabled = false;
        outputText.Clear();
        OutCode.Clear();
        OutCode.BackColor = SystemColors.Control;
        ThreadPool.QueueUserWorkItem(ExecuteTextInput);
    }
    
    #endregion

}