import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

export default defineConfig({
  base: '/client/',
  plugins: [react()],
  build: {
    outDir: '../MyProject.MVC/wwwroot/client', // Build çıktısı burada olacak
    emptyOutDir: true,
    rollupOptions: {
      input: './src/main.jsx',
      output: {
        entryFileNames: 'bundle.js',
        assetFileNames: 'assets/[name]-[hash][extname]', // Görseller, fontlar vs
      }
    }
  }
});