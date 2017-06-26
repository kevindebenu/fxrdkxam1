using System;
using System.Drawing;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace FoxitRDK
{

	[BaseType(typeof(NSObject))]
	interface FSLibrary
	{
		[Static, Export("init:key:")]
		FSErrorCode Init(string sn, string key);
	}

	[BaseType(typeof(UIView))]
	interface FSPDFViewCtrl
	{
		[Export("initWithFrame:")]
		IntPtr Constructor(CGRect frame);

		[Export("setDoc:")]
		void SetDoc(FSPDFDoc doc);
	}

	[BaseType(typeof(NSObject))]
	interface FSPDFDoc
	{
		[Static, Export("createFromFilePath:")]
		FSPDFDoc CreateFromFilePath(string path);

		[Export("load:")]
		FSErrorCode Load(string password);
	}
}