// CS0221: Constant value `-Infinity' cannot be converted to a `ushort' (use `unchecked' syntax to override)
// Line: 6

class X {
	static void Main () {
		System.Console.WriteLine ((ushort)double.NegativeInfinity);
	}
}
