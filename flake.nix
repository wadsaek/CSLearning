{
  description = "A very basic flake";

  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs?ref=nixos-unstable";
    flake-utils.url = "github:numtide/flake-utils";
  };

  outputs =
    {
      self,
      nixpkgs,
      flake-utils,
    }:
    flake-utils.lib.eachDefaultSystemPassThrough (
      system:
      let
        pkgs = import nixpkgs { inherit system; };
      in
      {
        devShell.${system} = pkgs.mkShell {
          buildInputs = [
            pkgs.dotnetCorePackages.dotnet_9.sdk
          ];
        };
      }
    );
}
