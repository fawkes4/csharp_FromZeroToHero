using System;

namespace MusicBandSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicBand band = new MusicBand("zashkvarocka");

            Piano piano = new Piano();
            Violin violin = new Violin();
            MamsNerves nerves = new MamsNerves();
            Violin mozartViolin = new Violin();

            BandMember newBandMember = new BandMember("Volodymyr", piano);
            BandMember newBandMember2 = new BandMember("Ostap", mozartViolin);
            BandMember newBandMember3 = new BandMember("VasylDown", nerves);
            BandMember newBandMember4 = new BandMember("Yulia", violin);

            band.Add(newBandMember);
            band.Add(newBandMember2);
            band.Add(newBandMember3);
            band.Add(newBandMember4);

            band.Perform();

            //Create application which simulates music band:
            //• Band should have name and members;
            //• Band should NOT have 2 members playing the same instrument;
            //• Band should have method Perform;
            //     tip: to perform make all members of the band play their instruments
            //• Band can accept new members.If the new member plays the instrument which is already part of the band, the old member should leave the band;
            //• Musician should have name and be able to Play one instrument.Consider each musician can Play only one instrument;
            //     tip: use interface IMusicInstrument to show which instrument musician can play
            //• Each music instrument should have an ability to Sound
            //     tip: just print on Console something

            //example of GetType()

            //var kek = "kkk".GetType();
            //var lol = "kkk";
            //if (kek == typeof(string))
            //{
            //    Console.WriteLine("sdfdasfsda");
            //}

            //if (lol is string)
            //{
            //    Console.WriteLine("1112");
            //}

            //Console.WriteLine(kek);
        }

    }
}
