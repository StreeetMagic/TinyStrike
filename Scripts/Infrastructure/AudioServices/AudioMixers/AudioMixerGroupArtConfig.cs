using UnityEngine;

namespace AudioServices.AudioMixers
{
  [CreateAssetMenu(fileName = "AudioMixerGroup", menuName = "ArtConfigs/AudioMixerGroup")]
  public class AudioMixerGroupArtConfig : ArtConfig<AudioMixerGroupArtSetup>
  {
    protected override void Validate()
    {
    }
  }
}