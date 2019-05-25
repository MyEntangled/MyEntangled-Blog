namespace Quantum.Teleportation
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Math;

	operation initializeFirstQubit(q: Qubit) : Unit {
		// My desired state is the state created by rotating state |-⟩ 60 degrees about x, y, and z axes respectively.
		//Start from |0>
		X(q);
		H(q);
		Rx(PI()/3.0, q);
		Ry(PI()/3.0, q);
		Rz(PI()/3.0, q);
		//The final state will be be 0.9659|0⟩ - 0.2588|1⟩, so the probabilities are expected to be 0.9330 and 0.0670
	}
    
    operation Teleportation (count: Int) : (Int, Int) {
		mutable countZero = 0;
		mutable countOne = 0;

        using (qs = Qubit[3]) {
			for (test in 0..count) {
				// Create a special state a|0⟩ + b|1⟩ for the first qubit
				initializeFirstQubit(qs[0]);

				// Create Bell state for the two other qubits;
				H(qs[2]);
				CNOT(qs[2], qs[1]);

				// Entangle the first qubit to the pair in Bell state and change the basis for the first qubit
				CNOT(qs[0],qs[1]);
				H(qs[0]);

				// Measure and Restore based on measurements
				if (M(qs[1]) == One) {
					X(qs[2]);
				}
				if (M(qs[0]) == One) {
					Z(qs[2]);
				}

				// Measure the final qubit to statistically determine which state it's in 
				if (M(qs[2]) == Zero) {
					set countZero = countZero + 1;
				}
				else {
					set countOne = countOne + 1;
				}

				ResetAll(qs);
			}			
		}
		return (countZero, countOne);
    }
}
