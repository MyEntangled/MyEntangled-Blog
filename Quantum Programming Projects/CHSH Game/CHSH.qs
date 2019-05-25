namespace Quantum.CHSH
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Math;
	open Microsoft.Quantum.Extensions.Convert;

	operation Rotate_Measure (alpha: Double, q: Qubit): Int {
		Ry(2.0 * alpha, q);
		let m = M(q);
		Ry(-2.0 * alpha, q);
		if (m == One) {
			return 1;
		}
		return 0;
	}
    
    operation CHSH_Game (count: Int) : Int {
		mutable win = 0;
		mutable x = 0;
		mutable y = 0;
		mutable a = 0;
		mutable b = 0;

		using (qs = Qubit[2]) {
			for (test in 0 .. count) {
				set x = RandomInt(2);
				set y = RandomInt(2);
				set a = 0;
				set b = 0;

				H(qs[0]);
				CNOT(qs[0],qs[1]);

				if (x == 0) {
					if (M(qs[0]) == One) {
						set a = 1;
					}
				}	
				else {
					set a = Rotate_Measure(PI()/4.0, qs[0]);
				}

				if (y == 0) {
					set b = Rotate_Measure(PI()/8.0, qs[1]);
				}
				else {	
					set b = Rotate_Measure(-PI()/8.0, qs[1]);
				}

				if (x*y == (a+b) % 2) {
					set win = win + 1;
				}
				ResetAll(qs);
			}
		}
		return win;
    }
}
