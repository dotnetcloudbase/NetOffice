//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace LateBindingApi.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary MSProject 14, 
	 /// </summary>
	[SupportByLibrary("MSProject", 14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjOverallocationType
	{
		 /// <summary>
		 /// SupportByLibrary MSProject 14, 
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByLibrary("MSProject", 14)]
		 pjOverallocationTypeNone = 0,

		 /// <summary>
		 /// SupportByLibrary MSProject 14, 
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByLibrary("MSProject", 14)]
		 pjOverallocationTypeAboveMaxUnits = 1,

		 /// <summary>
		 /// SupportByLibrary MSProject 14, 
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByLibrary("MSProject", 14)]
		 pjOverallocationTypeWorkingInNonWorkingTime = 2,

		 /// <summary>
		 /// SupportByLibrary MSProject 14, 
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByLibrary("MSProject", 14)]
		 pjOverallocationTypeWorkingOnOtherTasks = 3
	}
}