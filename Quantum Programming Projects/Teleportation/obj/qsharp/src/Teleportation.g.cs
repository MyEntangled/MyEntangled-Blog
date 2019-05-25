#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Teleportation\",\"Name\":\"initializeFirstQubit\"},\"SourceFile\":\"C:/Users/trongduong/Documents/Visual%20Studio%202017/Projects/Bell/Teleportation/Teleportation.qs\",\"Position\":{\"Item1\":6,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Teleportation\",\"Name\":\"initializeFirstQubit\"},\"SourceFile\":\"C:/Users/trongduong/Documents/Visual%20Studio%202017/Projects/Bell/Teleportation/Teleportation.qs\",\"Position\":{\"Item1\":6,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Teleportation\",\"Name\":\"Teleportation\"},\"SourceFile\":\"C:/Users/trongduong/Documents/Visual%20Studio%202017/Projects/Bell/Teleportation/Teleportation.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.Teleportation\",\"Name\":\"Teleportation\"},\"SourceFile\":\"C:/Users/trongduong/Documents/Visual%20Studio%202017/Projects/Bell/Teleportation/Teleportation.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Teleportation
{
    public class initializeFirstQubit : Operation<Qubit, QVoid>, ICallable
    {
        public initializeFirstQubit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "initializeFirstQubit";
        String ICallable.FullName => "Quantum.Teleportation.initializeFirstQubit";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRx
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRz
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line 10 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
            MicrosoftQuantumPrimitiveX.Apply(q);
#line 11 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
            MicrosoftQuantumPrimitiveH.Apply(q);
#line 12 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
            MicrosoftQuantumPrimitiveRx.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), q));
#line 13 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
            MicrosoftQuantumPrimitiveRy.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), q));
#line 14 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
            MicrosoftQuantumPrimitiveRz.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 3D), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveRx = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rx));
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
            this.MicrosoftQuantumPrimitiveRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rz));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<initializeFirstQubit, Qubit, QVoid>(q);
        }
    }

    public class Teleportation : Operation<Int64, (Int64,Int64)>, ICallable
    {
        public Teleportation(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Teleportation";
        String ICallable.FullName => "Quantum.Teleportation.Teleportation";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> initializeFirstQubit
        {
            get;
            set;
        }

        public override Func<Int64, (Int64,Int64)> Body => (__in__) =>
        {
            var count = __in__;
#line 19 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
            var countZero = 0L;
#line 20 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
            var countOne = 0L;
#line hidden
            {
#line 22 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                var qs = Allocate.Apply(3L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 23 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                    foreach (var test in new Range(0L, count))
#line hidden
                    {
#line 25 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                        initializeFirstQubit.Apply(qs[0L]);
#line 28 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qs[2L]);
#line 29 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((qs[2L], qs[1L]));
#line 32 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
#line 33 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 36 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                        if ((M.Apply(qs[1L]) == Result.One))
                        {
#line 37 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                            MicrosoftQuantumPrimitiveX.Apply(qs[2L]);
                        }

#line 39 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                        if ((M.Apply(qs[0L]) == Result.One))
                        {
#line 40 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                            MicrosoftQuantumPrimitiveZ.Apply(qs[2L]);
                        }

#line 44 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                        if ((M.Apply(qs[2L]) == Result.Zero))
                        {
#line 45 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                            countZero = (countZero + 1L);
                        }
                        else
                        {
#line 48 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                            countOne = (countOne + 1L);
                        }

#line 51 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
                        ResetAll.Apply(qs?.Copy());
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(qs);
                }
            }

#line 54 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\Teleportation\\Teleportation.qs"
            return (countZero, countOne);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
            this.initializeFirstQubit = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(initializeFirstQubit));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 count)
        {
            return __m__.Run<Teleportation, Int64, (Int64,Int64)>(count);
        }
    }
}