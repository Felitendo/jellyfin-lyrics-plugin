# Jellyfin Lyrics Plugin

A plugin for Jellyfin that automatically downloads lyrics for your music library.

## 🎵 Features

- Automatic lyrics download for your entire music library
- Integrates seamlessly with Jellyfin's music player
- Downloads Lyrics directly from LrcLib
- Batch processing for large libraries
- Real-time lyrics display during playback

## 🚀 Installation

1. Ensure your Jellyfin server is updated to version 10.9.10 or above
2. Add the plugin repository to Jellyfin: https://raw.githubusercontent.com/Felitendo/jellyfin-lyrics-plugin/master/manifest.json
3. Navigate to the Plugin Catalog in your Jellyfin dashboard
4. Find "LrcLib" under the "Notifications" category and install it
5. Go to Scheduled Tasks and run "Download missing lyrics"
6. Scan all libraries to complete the integration

### 📝 Manual Refresh
If lyrics aren't appearing for specific albums:
1. Navigate to the album
2. Right-click
3. Select "Refresh metadata"

## ⚙️ Configuration

The plugin works out of the box with default settings, but you can customize:
- Lyrics sources priority
- Download schedule
- Display preferences
- Cache settings

## 🔍 Troubleshooting

### Common Issues
- **Lyrics not showing up?** Make sure you've completed all installation steps and refreshed metadata
- **Missing lyrics for specific songs?** Try manually refreshing the metadata for those items
- **Plugin not appearing?** Verify your Jellyfin version and repository URL

## 💡 Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

## 📞 Support

- Create an [Issue](https://github.com/yourusername/jellyfin-lyrics-plugin/issues)
- Join my [Discord Server](https://dsc.gg/felitendo)
