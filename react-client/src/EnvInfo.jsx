import process from 'process'

function EnvInfo() {
  return (
    <div style={{ padding: '1rem', backgroundColor: '#eee', borderRadius: '8px' }}>
      <h3>Environment Info</h3>
      <p><strong>Mode:</strong> {import.meta.env.MODE}</p>
      <p><strong>API URL:</strong> {import.meta.env.VITE_API_URL}</p>
    </div>
  );
}

export default EnvInfo;
