# FluentParticleSystem

English / [Japanese](README_ja.md)

このパッケージはUnityの`ParticleSystem`をメソッドチェーンで記述できるようにする拡張メソッド群を提供します

## installation

You can install this package using UPM (Unity Package Manager).

1. Open **Package Manager** Window
2. Click **Add**(+) on the status bar
3. Select **Add package from git URL**
4. Input `https://github.com/OUCC/FluentParticleSystem.git?path=Packages/FluentParticleSystem`
5. Click **Add**


## 使い方

```csharp
public class Foo : MonoBehavior
{
    public ParticleSystem particleSystem;

    private void Start()
    {
        // Set<モジュール名><項目名>で設定できます
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
