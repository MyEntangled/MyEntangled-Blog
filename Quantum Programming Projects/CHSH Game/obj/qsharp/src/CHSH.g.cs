#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.CHSH\",\"Name\":\"Rotate_Measure\"},\"SourceFile\":\"C:/Users/trongduong/Documents/Visual%20Studio%202017/Projects/Bell/QSharpApplication1/CHSH.qs\",\"Position\":{\"Item1\":7,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":43}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.CHSH\",\"Name\":\"Rotate_Measure\"},\"SourceFile\":\"C:/Users/trongduong/Documents/Visual%20Studio%202017/Projects/Bell/QSharpApplication1/CHSH.qs\",\"Position\":{\"Item1\":7,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.CHSH\",\"Name\":\"CHSH_Game\"},\"SourceFile\":\"C:/Users/trongduong/Documents/Visual%20Studio%202017/Projects/Bell/QSharpApplication1/CHSH.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":27}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.CHSH\",\"Name\":\"CHSH_Game\"},\"SourceFile\":\"C:/Users/trongduong/Documents/Visual%20Studio%202017/Projects/Bell/QSharpApplication1/CHSH.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.CHSH
{
    public class Rotate_Measure : Operation<(Double,Qubit), Int64>, ICallable
    {
        public Rotate_Measure(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Qubit)>, IApplyData
        {
            public In((Double,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Rotate_Measure";
        String ICallable.FullName => "Quantum.CHSH.Rotate_Measure";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        public override Func<(Double,Qubit), Int64> Body => (__in__) =>
        {
            var (alpha,q) = __in__;
#line 9 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            MicrosoftQuantumPrimitiveRy.Apply(((2D * alpha), q));
#line 10 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            var m = M.Apply(q);
#line 11 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            MicrosoftQuantumPrimitiveRy.Apply(((-(2D) * alpha), q));
#line 12 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            if ((m == Result.One))
            {
#line 13 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                return 1L;
            }

#line 15 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            return 0L;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
        }

        public override IApplyData __dataIn((Double,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Double alpha, Qubit q)
        {
            return __m__.Run<Rotate_Measure, (Double,Qubit), Int64>((alpha, q));
        }
    }

    public class CHSH_Game : Operation<Int64, Int64>, ICallable
    {
        public CHSH_Game(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CHSH_Game";
        String ICallable.FullName => "Quantum.CHSH.CHSH_Game";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonRandomInt
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

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

        protected ICallable<(Double,Qubit), Int64> Rotate_Measure
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in__) =>
        {
            var count = __in__;
#line 19 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            var win = 0L;
#line 20 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            var x = 0L;
#line 21 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            var y = 0L;
#line 22 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            var a = 0L;
#line 23 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            var b = 0L;
#line hidden
            {
#line 25 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 26 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                    foreach (var test in new Range(0L, count))
#line hidden
                    {
#line 27 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                        x = MicrosoftQuantumCanonRandomInt.Apply(2L);
#line 28 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                        y = MicrosoftQuantumCanonRandomInt.Apply(2L);
#line 29 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                        a = 0L;
#line 30 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                        b = 0L;
#line 32 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 33 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
#line 35 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                        if ((x == 0L))
                        {
#line 36 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                            if ((M.Apply(qs[0L]) == Result.One))
                            {
#line 37 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                                a = 1L;
                            }
                        }
                        else
                        {
#line 41 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                            a = Rotate_Measure.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 4D), qs[0L]));
                        }

#line 44 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                        if ((y == 0L))
                        {
#line 45 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                            b = Rotate_Measure.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 8D), qs[1L]));
                        }
                        else
                        {
#line 48 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                            b = Rotate_Measure.Apply(((-(MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 8D), qs[1L]));
                        }

#line 51 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                        if (((x * y) == ((a + b) % 2L)))
                        {
#line 52 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
                            win = (win + 1L);
                        }

#line 54 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
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

#line 57 "C:\\Users\\trongduong\\Documents\\Visual Studio 2017\\Projects\\Bell\\QSharpApplication1\\CHSH.qs"
            return win;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomInt));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Rotate_Measure = this.Factory.Get<ICallable<(Double,Qubit), Int64>>(typeof(Rotate_Measure));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 count)
        {
            return __m__.Run<CHSH_Game, Int64, Int64>(count);
        }
    }
}