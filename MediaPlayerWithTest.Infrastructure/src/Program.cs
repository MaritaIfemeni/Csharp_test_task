using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MediaPlayerWithTest.Application.src;
using MediaPlayerWithTest.Business.src.Sevice;
using MediaPlayerWithTest.Domain.src.Core.Entity;
using MediaPlayerWithTest.Infrastructure.src.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        // how client  interact with application - via controllers!!
        Console.WriteLine("Starting");

        var user = User.Instance;
        Console.WriteLine(user.GetId);
        var userRepository = new UserRepository();
        var userService = new UserService(userRepository);
        var userController = new UserController(userService);
        var mediaRepository = new MediaRepository();
        var mediaService = new MediaService(mediaRepository);
        var mediaController = new MediaController(mediaService);

        var playListRepository = new PlayListRepository(mediaRepository);
        var playListService = new PlayListService(playListRepository);
        var playListController = new PlayListController(playListService);
    
        var lsita = userController.AddNewList("test11", user.GetId);
        user.AddNewList(lsita);
        var lsita2 = userController.AddNewList("test22", user.GetId);
        user.AddNewList(lsita2);
        var mediaa = mediaController.CreateNewFile<Audio>("test", "AUDIO", TimeSpan.FromSeconds(100));
        var mediaa2 = mediaController.CreateNewFile<Audio>("test2", "AUDIO", TimeSpan.FromSeconds(1040));
        var mediaa3 = mediaController.CreateNewFile<Video>("test3", "VIDEO", TimeSpan.FromSeconds(1000));
        var mediaa4 = mediaController.CreateNewFile<Video>("test4", "VIDEO", TimeSpan.FromSeconds(10));

        playListController.AddNewFile(lsita.GetId, mediaa.GetId, user.GetId);
        playListController.AddNewFile(lsita.GetId, mediaa2.GetId, user.GetId);
        playListController.AddNewFile(lsita.GetId, mediaa3.GetId, user.GetId);

        foreach (var item in mediaRepository.GetAllFiles())
        {
            Console.WriteLine(item.FileName);
        }
    
        foreach (var item in user.GetAllLists)
        {
            Console.WriteLine(item.ListName);
        }
        playListController.RemoveFile(lsita.GetId, mediaa.GetId, user.GetId);
        userController.RemoveAllLists(user.GetId);
  
        foreach (var item in user.GetAllLists)
        {
            Console.WriteLine("Onko poistettu?" + item.ListName);
        }
    
        Console.WriteLine("End");


        /* command-line interface should be here. All the methods should be used from class controllers only */
    }
}