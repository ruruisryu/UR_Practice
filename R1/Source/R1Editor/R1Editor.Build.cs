// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class R1Editor : ModuleRules
{
	public R1Editor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		// 우리 R1Editor 모듈은 언리얼의 "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" 모듈들을 사용하겠다! 는 뜻 -> 종속성 표시
		// R1EditorModule.cpp에서 R1Actor.h를 include하고 있으므로 R1 모듈에 대한 종속성도 추가해줌.
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "R1" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
