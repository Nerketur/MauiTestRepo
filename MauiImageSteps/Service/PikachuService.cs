using MauiImageSteps.Model;
using System.Collections.ObjectModel;

namespace MauiImageSteps.Service
{
    public class PikachuService {
        public async Task Init() {

        }

        public async Task<ObservableCollection<Pikachu>> GetPikachusAsync() {
            await Init();
            ObservableCollection<Pikachu> result = new() {
                new Pikachu { Name = "Pika", Location = "Pokeball", Details = "details1", ImageUrl = "pikachu1.png" },
                new Pikachu { Name = "Joltz", Location = "Trainer", Details = "details2", ImageUrl = "pikachu2.png" },
                new Pikachu { Name = "Thunder", Location = "Forest", Details = "details3", ImageUrl = "pikachu3.png" },
                new Pikachu { Name = "Shocker", Location = "Unknown", Details = "details4", ImageUrl = "pikachu4.png" },
                new Pikachu { Name = "Zaps", Location = "Jungle", Details = "details5", ImageUrl = "pikachu5.png" }
            };
            return result;
        }
    }
}