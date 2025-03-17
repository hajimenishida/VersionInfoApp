using System;
using System.Reflection;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // �o�[�W�������̎擾
        var version = Assembly.GetExecutingAssembly().GetName().Version;
        string commitHash = GetGitCommitHash();

        // �o�[�W��������Git�̃R�~�b�g�n�b�V����\��
        Console.WriteLine($"Version: {version}");
        Console.WriteLine($"Git Commit Hash: {commitHash}");
    }

    // Git�̃R�~�b�g�n�b�V�����擾���郁�\�b�h
    static string GetGitCommitHash()
    {
        try
        {
            // Git�̃R�}���h�����s���čŐV�̃R�~�b�g�n�b�V�����擾
            var processStartInfo = new ProcessStartInfo("git", "rev-parse --short HEAD")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            var process = Process.Start(processStartInfo);
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd().Trim();
        }
        catch
        {
            return "Unknown";
        }
    }
}
