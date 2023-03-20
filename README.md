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
        // Assign value with Set<Module Name><Property Name>
        particleSystem.SetMainDuration(5.0f);

        // 現在の設定値を利用して変更できます
        particleSystem.SetMainDuration(d => d * 2);

        // 返り値は ParticleSystem なのでメソッドチェーンで続けて書けます
        particleSystem.SetMainDuration(5.0f)
            .SetMainLoop(true)
            .SetCollisionDampen(0.1f);

        // Edit<モジュール名> を使うことで一つのモジュールについて一度に設定できます
        particleSystem
            .EditMain(m =>
                m.SetDuration(5.0f)
                 .SetLoop(l => !l))
            .SetCollisionDampen(0.1f);
    }
}
```
