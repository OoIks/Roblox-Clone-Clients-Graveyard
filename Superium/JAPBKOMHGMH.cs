// JAPBKOMHGMH
using MoonSharp.Interpreter;
using UnityEngine;

public static class JAPBKOMHGMH
{
	public static void JAGJBICIOMH()
	{
		Script.GlobalOptions.CustomConverters.SetScriptToClrCustomConversion(DataType.Table, typeof(Vector2), delegate(DynValue JKGHELMLDOF)
		{
			Table table2 = JKGHELMLDOF.Table;
			float x2 = (float)(double)table2[1];
			float y2 = (float)(double)table2[2];
			return new Vector2(x2, y2);
		});
		Script.GlobalOptions.CustomConverters.SetClrToScriptCustomConversion(delegate(Script BLFGOOLHDLK, Vector2 FJKPDDEPHAP)
		{
			DynValue dynValue4 = DynValue.NewNumber(FJKPDDEPHAP.x);
			DynValue dynValue5 = DynValue.NewNumber(FJKPDDEPHAP.y);
			return DynValue.NewTable(BLFGOOLHDLK, dynValue4, dynValue5);
		});
		Script.GlobalOptions.CustomConverters.SetScriptToClrCustomConversion(DataType.Table, typeof(Vector3), delegate(DynValue JKGHELMLDOF)
		{
			Table table = JKGHELMLDOF.Table;
			float x = (float)(double)table[1];
			float y = (float)(double)table[2];
			float z = (float)(double)table[3];
			return new Vector3(x, y, z);
		});
		Script.GlobalOptions.CustomConverters.SetClrToScriptCustomConversion(delegate(Script BLFGOOLHDLK, Vector3 FJKPDDEPHAP)
		{
			DynValue dynValue = DynValue.NewNumber(FJKPDDEPHAP.x);
			DynValue dynValue2 = DynValue.NewNumber(FJKPDDEPHAP.y);
			DynValue dynValue3 = DynValue.NewNumber(FJKPDDEPHAP.z);
			return DynValue.NewTable(BLFGOOLHDLK, dynValue, dynValue2, dynValue3);
		});
	}
}
