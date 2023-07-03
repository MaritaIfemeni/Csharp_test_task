# MediaPlayerWithTest Solution Assignment C#

The purpose of this assigment was to modify the ready made solution with a clean architecture and to test the solution with unit tests.

## Missing features

- No error handling had been done
- No all tests had been done 
- Not all test has been passed (issues with the build giving the roslyn error again and again even getting rid of it, it comes again)
- No user interface had been done

## Used technologies

- C#
- Xunit
- Moq
- Clean architecture

## File structure
```
.
├── MediaPlayerWithTest.Application
│   ├── MediaPlayerWithTest.Application.csproj
│   ├── bin
│   ├── obj
│   └── src
│       ├── MediaController.cs
│       ├── PlayListController.cs
│       └── UserController.cs
├── MediaPlayerWithTest.Business
│   ├── MediaPlayerWithTest.Business.csproj
│   ├── bin
│   ├── obj
│   └── src
│       ├── ServiceInterface
│       │   ├── IMediaService.cs
│       │   ├── IPlayListService.cs
│       │   └── IUserService.cs
│       └── Sevice
│           ├── MediaService.cs
│           ├── PlayListService.cs
│           └── UserService.cs
├── MediaPlayerWithTest.Domain
│   ├── MediaPlayerWithTest.Domain.csproj
│   ├── bin
│   ├── obj
│   └── src
│       ├── Core
│       │   └── Entity
│       │       ├── Audio.cs
│       │       ├── BaseEntity.cs
│       │       ├── MediaFile.cs
│       │       ├── MediaType.cs
│       │       ├── PlayList.cs
│       │       ├── User.cs
│       │       └── Video.cs
│       ├── Factory
│       │   └── MediaFactory.cs
│       ├── FactoryInterface
│       │   └── IMediaFactory.cs
│       └── RepositoryInterface
│           ├── IMediaRepository.cs
│           ├── IPlayListRepository.cs
│           └── IUserRepository.cs
├── MediaPlayerWithTest.Infrastructure
│   ├── MediaPlayerWithTest.Infrastructure.csproj
│   ├── bin
│   ├── obj
│   └── src
│       ├── Program.cs
│       └── Repository
│           ├── MediaRepository.cs
│           ├── PlayListRepository.cs
│           └── UserRepository.cs
├── MediaPlayerWithTest.Tests
│   ├── MediaPlayerWithTest.Tests.csproj
│   ├── bin
│   ├── obj
│   └── src
│       ├── Domain.Tests
│       │   ├── AudioTest.cs
│       │   ├── UnitTest1.cs
│       │   ├── UserTest.cs
│       │   └── VideoTest.cs
│       ├── Service.Tests
│       │   ├── MediaServiceTest.cs
│       │   └── PlaylistServiceTest.cs
│       └── Usings.cs
├── MediaPlayerWithTest.sln
└── README.md