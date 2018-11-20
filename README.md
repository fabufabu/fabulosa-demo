# Fabulosa Demo

# Build for production

Run: `./fake.sh build`

All the files needed for deployment are under the `output` folder.

# Watch mode

Run: `./fake.sh build -t Watch`

# Running Fable without FAKE

- Install NPM dependencies: `yarn`
- Install Nuget dependencies: `dotnet restore build.proj`
- Building for development: `dotnet fable webpack-dev-server`
- Building for production: `dotnet fable webpack-cli`
