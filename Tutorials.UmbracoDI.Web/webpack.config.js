/// <binding ProjectOpened='Watch - Development' />
// if you get a node sass error, try running "npm rebuild node-sass" from the package manager console
const path = require('path');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const CopyWebpackPlugin = require('copy-webpack-plugin');

module.exports = {
    mode: 'production',
    resolve: {
        alias: {
            Assets: path.resolve(__dirname, 'Assets')
        }
    },
    entry: {
        UmbracoDI: 'Assets/webpackEntry.js'
    },
    output: {
        path: path.resolve(__dirname, 'Assets/Dist'),
        filename: '[name].js'
    },
    module: {
        rules: [
            {
                test: /\.scss$/,
                use: ExtractTextPlugin.extract({
                    use: [
                        'css-loader',
                        {
                            loader: 'sass-loader'
                        }
                    ]
                })
            }
        ]
    },
    plugins: [
        new ExtractTextPlugin('[name].css'),
        new CopyWebpackPlugin([
			// copy all needed vendor files from node modules to dist folder, example below
            // { from: 'node_modules/@fortawesome/fontawesome-free/css/all.css', to: path.resolve(__dirname, 'assets/dist/vendor/fontawesome/css') },
        ])
    ]
};