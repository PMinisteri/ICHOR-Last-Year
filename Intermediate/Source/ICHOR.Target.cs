using UnrealBuildTool;

public class ICHORTarget : TargetRules
{
	public ICHORTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ICHOR");
	}
}
