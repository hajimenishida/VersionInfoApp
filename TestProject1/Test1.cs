using Microsoft.VisualStudio.TestTools.UnitTesting;
using VersionInfoApp;

[TestClass]
public class VersionTests
{
    [TestMethod]
    public void Version_ShouldContainCommitHash()
    {
        // バージョン情報の取得
        string version = new VersionHelperLibrary().GetVersion();

        // "+"以降にGitコミットハッシュが存在することを確認
        StringAssert.Contains(version, "+");
        string[] parts = version.Split('+');
        Assert.IsTrue(parts.Length > 1 && parts[1].Length >= 7, "バージョン情報にコミットハッシュが正しく含まれていません。");
    }
}
