using System.IO;

namespace racing_game
{
    public class CAudio
    {
        private System.Media.SoundPlayer _player = new System.Media.SoundPlayer(@"Content\Audio\titlescreen.vta");
        
        public CAudio() {}

        public void Play()
        {
            _player.Play();
        }

        public void PlayLoop()
        {
            _player.PlayLooping();
        }

        public void Stop()
        {
            _player.Stop();
        }
    }
}