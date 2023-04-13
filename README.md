# FluentParticleSystem

[![openupm](https://img.shields.io/npm/v/org.oucc.fluent-particle-system?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/org.oucc.fluent-particle-system/)

English / [Japanese](README_ja.md)

This package provides extension methods to write `ParticleSystem` of Unity with method chains.

## Installation

You can install this package using UPM (Unity Package Manager).

### Use Git URL

1. Open **Package Manager** Window
2. Click **Add**(+) on the status bar
3. Select **Add package from git URL**
4. Input `https://github.com/OUCC/FluentParticleSystem.git?path=Packages/FluentParticleSystem`
5. Click **Add**

### Use OpenUPM

=> [OpenUPM Page](https://openupm.com/packages/org.oucc.fluent-particle-system/)

via command-line interface
```bash
$ openupm add org.oucc.fluent-particle-system
```

## Usage

If you are using Assembly Deffinition, add `OUCC.FluentParticleSystem` to the `Assembly Definition References`

```csharp
public class Foo : MonoBehavior
{
    public ParticleSystem particleSystem;

    private void Start()
    {
        // Assign value with Set<ModuleName><PropertyName>
        particleSystem.SetMainDuration(5.0f);

        // You can change the value with the current value.
        particleSystem.SetMainDuration(d => d * 2);

        // You can write with method chains
        particleSystem.SetMainDuration(5.0f)
            .SetMainLoop(true)
            .SetCollisionDampen(0.1f);

        // Using Edit<ModuleName>, configure some settings of a module at a time
        particleSystem
            .EditMain(m =>
                m.SetDuration(5.0f)
                 .SetLoop(l => !l))
            .SetCollisionDampen(0.1f);
    }
}
```

## Definition

The extension methods provided are defined as follows

```csharp
namespace OUCC.FluentParticleSystem
{
    public static class MainModuleExtension
    {
        public static ParticleSystem EditMain(this ParticleSystem particleSystem, Action<MainModule> moduleEditor);

        public static ParticleSystem SetMainCullingMode(this ParticleSystem particleSystem, ParticleSystemCullingMode cullingMode);

        public static ParticleSystem SetMainCullingMode(this ParticleSystem particleSystem, Func<ParticleSystemCullingMode, ParticleSystemCullingMode> cullingModeChanger);

        public static MainModule SetCullingMode(this MainModule module, ParticleSystemCullingMode cullingMode);

        public static MainModule SetCullingMode(this MainModule module, Func<ParticleSystemCullingMode, ParticleSystemCullingMode> cullingModeChanger);
    }
}
```
