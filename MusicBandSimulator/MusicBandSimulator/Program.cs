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

            BandMember newBandMember = new BandMember("volodymyr", piano);
            BandMember newBandMember2 = new BandMember("yulia", violin);
            BandMember newBandMember3 = new BandMember("vasylDown", nerves);
            BandMember newBandMember4 = new BandMember("ostapDown", violin);

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

        }

    }
}
