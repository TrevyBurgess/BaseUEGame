# This is a template for creating UE5 games

This includes some useful configurations, including...

## 1. GitHub integration [Git Integration](https://www.youtube.com/watch?v=n3x1fErlmYA)

Install software

1. [Install Git LFS](https://git-lfs.github.com/)
1. [Install GitHub Desktop](https://desktop.github.com/)
1. [Install Git Console](https://git-scm.com/)

Include Git customization

1. .gitignore: Used to ignore dynamically generated files
1. .gitattributes: for large files that included in the LFS

Make sure LFS is running

1. Run Git Bash console
1. Run: git lfs install

1. Open GitHub Desktop
1. If tracked, remove project
1. Re-add project. You know it worked when it asks you to Initialize GIT LFS

### 1.1. Do we need the contents of these folders

1. Intermediate
1. Binaries
1. \*.log

## 2. Customization

### 2.1. Displacement - nanite-tessellation

**Note:** Demo project already has this

[UE5 Nanite Tessellation](https://unrealstack.com/how-to-use-ue5-nanite-tessellation/)

1. [Material texture](https://www.youtube.com/watch?v=oRDmp0RLy7Q)
1. Open Config/DefaultEngine.ini
1. Go to [/Script/Engine.RendererSettings]

1. Add: r.Nanite.Tessellation=1
1. Add: r.Nanite.AllowTessellation=1

#### **Can be enabled or disabled in Console**

1. Enter: r.Nanite.Tessellation 1

#### **Enable Nanite in Landscape**

**NOTE:** Remember to enable Nanite in all your assets

[Nanite](https://dev.epicgames.com/documentation/en-us/unreal-engine/nanite-virtualized-geometry-in-unreal-engine)

## 3. Plugins

| Plug In                                 | description                 |
| --------------------------------------- | --------------------------- |
| Landscape Patch                         |                             |
| Text 3D                                 |                             |
| Water, Water Advanced                   |                             |
| Advanced Quest System                   |                             |
| Animation Locomotion Library            | For accurate foot placement |
| Modeling Tools Editor Mode              |                             |
| Procedural Content Generation Framework |                             |
