#addin "wk.StartProcess"
#addin "wk.ProjectParser"

using PS = StartProcess.Processor;
using ProjectParser;

var name = "IssueML";

var currentDir = new DirectoryInfo(".").FullName;
var publishDir = ".publish/W";
var dateVersion = DateTime.Now.ToString("yy.MM.dd.HHmm");
var version = Argument("vv", dateVersion);

Task("Publish").Does(() => {
    var settings = new DotNetCoreMSBuildSettings();
    settings.Properties["Version"] = new string[] { version };

    CleanDirectory(publishDir);
    DotNetCorePublish($"src/{name}", new DotNetCorePublishSettings {
        OutputDirectory = publishDir,
        MSBuildSettings = settings
    });
});

var target = Argument("target", "Pack");
RunTarget(target);