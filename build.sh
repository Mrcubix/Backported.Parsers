dotnet publish ./Backported.Parsers/Backported.Parsers.csproj -c Release -o ./build

(
  cd build
  
  # zip the Preset.Binding.dll
  jar -cfM Backported.Parsers.zip ./*.dll

  # generate hashes
  sha256sum Backported.Parsers.zip >> hashes.txt
)