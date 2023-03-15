internal class Program

       public enum Buah
{
    Apel,
    Aprikot,
    Alpukat,
    Pisang,
    Paprika,
    Blackberry,
    Ceri,
    Kelapa,
    Jagung
}
        public enum charState
{
    Jongkok, Berdiri, Tengkurap, Terbang
}

        public enum Trigger
{
    TombolS, TombolW,TombolX
}
public class KodeBuah
{
    public string getKodeBuah(Buah buah)
    {
        string[] isKodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
        int inputKodeBuah = (int)buah;
        return isKodeBuah[inputKodeBuah];
    }
}

public class PosisikarakterGame
{
    public class Transisi
    {
        public charState firstState;
        public charState lastState;
        public Trigger trigger;

        public Transisi(charState firstState, charState lastState, Trigger trigger)
        {
            this.firstState = firstState;
            this.lastState = lastState;
            this.trigger = trigger;
        }
    }
    Transisi[] transisi =
    {
        new Transisi(charState.Jongkok,charState.Berdiri,Trigger.TombolW),
        new Transisi(charState.Berdiri,charState.Jongkok,Trigger.TombolS),
        new Transisi(charState.Berdiri,charState.Terbang,Trigger.TombolW),
        new Transisi(charState.Terbang,charState.Berdiri,Trigger.TombolS),
        new Transisi(charState.Jongkok,charState.Tengkurap,Trigger.TombolS),
        new Transisi(charState.Tengkurap,charState.Jongkok,Trigger.TombolW),
        new Transisi(charState.Terbang,charState.Jongkok,Trigger.TombolX),
    };




        
}
