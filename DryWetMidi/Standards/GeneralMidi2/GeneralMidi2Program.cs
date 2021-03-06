﻿namespace Melanchall.DryWetMidi.Standards
{
    public enum GeneralMidi2Program
    {
        // Piano

        AcousticGrandPiano,
        AcousticGrandPiano_Wide,
        AcousticGrandPiano_Dark,
        BrightAcousticPiano,
        BrightAcousticPiano_Wide,
        ElectricGrandPiano,
        ElectricGrandPiano_Wide,
        HonkyTonkPiano,
        HonkyTonkPiano_Wide,
        ElectricPiano1,
        DetunedElectricPiano1,
        ElectricPiano1_VelocityMix,
        SixtiesElectricPiano,
        ElectricPiano2,
        DetunedElectricPiano2,
        ElectricPiano2_VelocityMix,
        EpLegend,
        EpPhase,
        Harpsichord,
        Harpsichord_OctaveMix,
        Harpsichord_Wide,
        Harpsichord_WithKeyOff,
        Clavi,
        PulseClavi,

        // Chromatic Percussion

        Celesta,
        Glockenspiel,
        MusicBox,
        Vibraphone,
        Vibraphone_Wide,
        Marimba,
        Marimba_Wide,
        Xylophone,
        TubularBells,
        ChurchBell,
        Carillon,
        Dulcimer,

        // Organ

        DrawbarOrgan,
        DetunedDrawbarOrgan,
        ItalianSixtiesOrgan,
        DrawbarOrgan2,
        PercussiveOrgan,
        DetunedPercussiveOrgan,
        PercussiveOrgan2,
        RockOrgan,
        ChurchOrgan,
        ChurchOrgan_OctaveMix,
        DetunedChurchOrgan,
        ReedOrgan,
        PuffOrgan,
        Accordion,
        Accordion2,
        Harmonica,
        TangoAccordion,

        // Guitar

        AcousticGuitar_Nylon,
        Ukulele,
        AcousticGuitar_NylonKeyOff,
        AcousticGuitar_Nylon2,
        AcousticGuitar_Steel,
        TwelveStringsGuitar,
        Mandolin,
        SteelGuitarWithBodySound,
        ElectricGuitar_Jazz,
        ElectricGuitar_PedalSteel,
        ElectricGuitar_Clean,
        ElectricGuitar_DetunedClean,
        MidToneGuitar,
        ElectricGuitar_Muted,
        ElectricGuitar_FunkyCutting,
        ElectricGuitar_MutedVeloSw,
        JazzMan,
        OverdrivenGuitar,
        GuitarPinch,
        DistortionGuitar,
        DistortionGuitar_WithFeedback,
        DistortedRhythmGuitar,
        GuitarHarmonics,
        GuitarFeedback,

        // Bass

        AcousticBass,
        ElectricBass_Finger,
        FingerSlapBass,
        ElectricBass_Pick,
        FretlessBass,
        SlapBass1,
        SlapBass2,
        SynthBass1,
        SynthBass_Warm,
        SynthBass3_Resonance,
        ClaviBass,
        Hammer,
        SynthBass2,
        SynthBass4_Attack,
        SynthBass_Rubber,
        AttackPulse,

        //  Strings & Orchestral instruments

        Violin,
        Violin_SlowAttack,
        Viola,
        Cello,
        Contrabass,
        TremoloStrings,
        PizzicatoStrings,
        OrchestralHarp,
        YangChin,
        Timpani,

        // Ensemble

        StringEnsembles1,
        StringsAndBrass,
        SixtiesStrings,
        StringEnsembles2,
        SynthStrings1,
        SynthStrings3,
        SynthStrings2,
        ChoirAahs,
        ChoirAahs2,
        VoiceOohs,
        Humming,
        SynthVoice,
        AnalogVoice,
        OrchestraHit,
        BassHitPlus,
        SixthHit,
        EuroHit,

        // Brass

        Trumpet,
        DarkTrumpetSoft,
        Trombone,
        Trombone2,
        BrightTrombone,
        Tuba,
        MutedTrumpet,
        MutedTrumpet2,
        FrenchHorn,
        FrenchHorn2_Warm,
        BrassSection,
        BrassSection2_OctaveMix,
        SynthBrass1,
        SynthBrass3,
        AnalogSynthBrass1,
        JumpBrass,
        SynthBrass2,
        SynthBrass4,
        AnalogSynthBrass2,

        // Reed

        SopranoSax,
        AltoSax,
        TenorSax,
        BaritoneSax,
        Oboe,
        EnglishHorn,
        Bassoon,
        Clarinet,

        // Pipe

        Piccolo,
        Flute,
        Recorder,
        PanFlute,
        BlownBottle,
        Shakuhachi,
        Whistle,
        Ocarina,

        // Synth Lead

        Lead1_Square,
        Lead1A_Square2,
        Lead1B_Sine,
        Lead2_Sawtooth,
        Lead2A_Sawtooth2,
        Lead2B_SawPulse,
        Lead2C_DoubleSawtooth,
        Lead2D_SequencedAnalog,
        Lead3_Calliope,
        Lead4_Chiff,
        Lead5_Charang,
        Lead5A_WireLead,
        Lead6_Voice,
        Lead7_Fifths,
        Lead8_BassLead,
        Lead8A_SoftWrl,

        //  Synth Pad

        Pad1_NewAge,
        Pad2_Warm,
        Pad2A_SinePad,
        Pad3_Polysynth,
        Pad4_Choir,
        Pad4A_Itopia,
        Pad5_Bowed,
        Pad6_Metallic,
        Pad7_Halo,
        Pad8_Sweep,

        //  Synth SFX

        Fx1_Rain,
        Fx2_Soundtrack,
        Fx3_Crystal,
        Fx3A_SynthMallet,
        Fx4_Atmosphere,
        Fx5_Brightness,
        Fx6_Goblins,
        Fx7_Echoes,
        Fx7A_EchoBell,
        Fx7B_EchoPan,
        Fx8_SciFi,

        // Ethnic Misc.

        Sitar,
        Sitar2_Bend,
        Banjo,
        Shamisen,
        Koto,
        TaishoKoto,
        Kalimba,
        BagPipe,
        Fiddle,
        Shanai,

        // Percussive

        TinkleBell,
        Agogo,
        SteelDrums,
        Woodblock,
        Castanets,
        TaikoDrum,
        ConcertBassDrum,
        MelodicTom,
        MelodicTom2_Power,
        SynthDrum,
        RhythmBoxTom,
        ElectricDrum,
        ReverseCymbal,

        // SFX

        GuitarFretNoise,
        GuitarCuttingNoise,
        AcousticBassStringSlap,
        BreathNoise,
        FluteKeyClick,
        Seashore,
        Rain,
        Thunder,
        Wind,
        Stream,
        Bubble,
        BirdTweet,
        Dog,
        HorseGallop,
        BirdTweet2,
        TelephoneRing,
        TelephoneRing2,
        DoorCreaking,
        Door,
        Scratch,
        WindChime,
        Helicopter,
        CarEngine,
        CarStop,
        CarPass,
        CarCrash,
        Siren,
        Train,
        Jetplane,
        Starship,
        BurstNoise,
        Applause,
        Laughing,
        Screaming,
        Punch,
        HeartBeat,
        Footsteps,
        Gunshot,
        MachineGun,
        Lasergun,
        Explosion
    }
}
