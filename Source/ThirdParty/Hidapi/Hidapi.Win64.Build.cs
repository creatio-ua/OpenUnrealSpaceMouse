// Copyright 2018-2020 David Morasz All Rights Reserved.

using UnrealBuildTool;

public partial class Hidapi : ModuleRules
{
	partial void SetupLibrary_Win64(ReadOnlyTargetRules target)
	{
		// This is generated code, not intended to be modified
		/*
			Using hidapi 0.14.0 
			A Simple cross-platform library for communicating with HID devices

			Current options:
				debug: false
				runtimes: MD
				shared: false
				pic: true

			Library options help:
				
		*/
		PublicAdditionalLibraries.Add($"{ModuleDirectory}/LibraryFiles/hidapi/Libs/Win64/{LibraryConfig}/hidapi.lib");
		
		PlatformSetup = true;
	}
}