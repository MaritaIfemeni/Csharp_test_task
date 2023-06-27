using MediaPlayerWithTest.Application.src;
using MediaPlayerWithTest.Business.src.Sevice;
using MediaPlayerWithTest.Domain.src.Core;
using MediaPlayerWithTest.Infrastructure.src.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        // how client interact with application - via controllers
        Console.WriteLine("Starting");

        var user = User.Instance;
        var userRepository = new UserRepository();
        var userService = new UserService(userRepository);
        var userController = new UserController(userService);
   
        var mediaRepository = new MediaRepository();
        var mediaService = new MediaService(mediaRepository);
        var mediaController = new MediaController(mediaService);

        var playListRepository = new PlayListRepository();
        var playListService = new PlayListService(playListRepository);
        var playListController = new PlayListController(playListService);

        /* command-line interface should be here. All the methods should be used from class controllers only */
    }
}