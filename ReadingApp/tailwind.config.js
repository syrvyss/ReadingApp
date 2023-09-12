/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{razor,html,cshtml}"],
    theme: {
        colors: {
            "primary": "#dac0a3",
            "secondary": "#eadbc8",
            "tertiary": "#f8f0e5",
            "black": "#0f2c59"
        },
        extend: {},
    },
    plugins: [
        require('@tailwindcss/forms')
    ],
}

