using System;
using OWOHaptic;

namespace MyOWOSensations
{
    public class MySensations
    {
        public static IOWOSensation Explosion => new OWOSensation(100, 0.1f, 100);
        OWOSensationWithMuscles ExplosionBelly = new OWOSensationWithMuscles(Explosion, OWOMuscle.Abdominal_Left, OWOMuscle.Abdominal_Right, OWOMuscle.Lumbar_Left, OWOMuscle.Lumbar_Right);
        OWOSensationsChain Healing = new OWOSensationsChain(Explosion, Explosion);

    }
}