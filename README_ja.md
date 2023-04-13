# FluentParticleSystem

[![openupm](https://img.shields.io/npm/v/org.oucc.fluent-particle-system?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/org.oucc.fluent-particle-system/)

[English](README.md) / Japanese

このパッケージはUnityの`ParticleSystem`を で記述できるようにする拡張メソッド群を提供します

## インストール方法

このパッケージは UPM(Unity Package Manager) を利用してインストールすることができます。

### Use Git URL

1. **Package Manager** ウィンドウを開く
2. ステータスバーの **Add**(+) をクリック
3. **Add package from git URL** を選択
4. `https://github.com/OUCC/FluentParticleSystem.git?path=Packages/FluentParticleSystem` を入力
5. **Add** をクリック

### Use OpenUPM

=> [OpenUPM Page](https://openupm.com/packages/org.oucc.fluent-particle-system/)

コマンドラインを使用する場合
```bash
$ openupm add org.oucc.fluent-particle-system
```

## 使い方

Assembly Deffinition を使用している場合は, `OUCC.FluentParticleSystem` を `Assembly Definition References` に追加します

```csharp
public class Foo : MonoBehavior
{
    public ParticleSystem particleSystem;

    private void Start()
    {
        // Set<モジュール名><項目名> で設定できます
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

## 定義

提供している拡張メソッドは以下のように定義されています。

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
