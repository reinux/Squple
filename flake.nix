{
  description = "Squple";

  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs?ref=nixos-unstable";
  };

  outputs = { self, nixpkgs }: 
    let 
      allSystems = [
        "x86_64-linux"
      ];

      forAllSystems = f: nixpkgs.lib.genAttrs allSystems (system: f {
        pkgs = import nixpkgs {inherit system;};
      });
    in {

      devShells = forAllSystems ({pkgs}: {
        default = pkgs.mkShell {
          packages = with pkgs; [
            dotnetCorePackages.sdk_8_0_1xx
          ];
        };
      });
    };
}
