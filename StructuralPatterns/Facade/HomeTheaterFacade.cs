using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    internal class HomeTheaterFacade
    {
        private DvdPlayer dvdPlayer;
        private Projector projector;
        private Lights lights;
        private SoundSystem soundSystem;

        public HomeTheaterFacade()
        {
            dvdPlayer = new DvdPlayer();
            projector = new Projector();
            lights = new Lights();
            soundSystem = new SoundSystem();
        }

        public void PlayMovie(string movie)
        {
            Console.WriteLine("Iniciando sessão de cinema. Filme (" + movie + ")");
            lights.Off();
            projector.On();
            soundSystem.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            dvdPlayer.Stop();
            soundSystem.Off();
            projector.Off();
            lights.On();
            Console.WriteLine("Sessão de cinema encerrada.");
        }
    }
}
