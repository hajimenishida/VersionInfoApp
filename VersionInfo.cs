using System;
using System.Reflection;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // バージョン情報の取得
        var version = Assembly.GetExecutingAssembly().GetName().Version;
        string commitHash = GetGitCommitHash();

        // バージョン情報とGitのコミットハッシュを表示
        Console.WriteLine($"Version: {version}");
        Console.WriteLine($"Git Commit Hash: {commitHash}");
    }

    // Gitのコミットハッシュを取得するメソッド
    static string GetGitCommitHash()
    {
        try
        {
            // Gitのコマンドを実行して最新のコミットハッシュを取得
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
